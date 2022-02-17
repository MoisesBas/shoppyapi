using Microsoft.EntityFrameworkCore;
using ShoppyEx.Order.Core.Domain.Basket;
using ShoppyEx.Order.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Order.Api.Features.BasketItem.Change
{
    public class ChangeBasketCommandHandler : CommandHandler<ChangeBasketCommand, Guid>
    {
        private readonly IOrderUnitOfWork _orderUnitOfWork;
        private readonly CustomerGrpc.CustomerGrpcClient _customerGrpcClient;
        private readonly ProductGrpc.ProductGrpcClient _productGrpcClient;

        public ChangeBasketCommandHandler(IOrderUnitOfWork orderUnitOfWork, CustomerGrpc.CustomerGrpcClient customerGrpcClient,
            ProductGrpc.ProductGrpcClient productGrpcClient)
        {
            _orderUnitOfWork = orderUnitOfWork;
            _customerGrpcClient = customerGrpcClient;
            _productGrpcClient = productGrpcClient;

        }

        public override async Task<Guid> ExecuteCommand(ChangeBasketCommand command, CancellationToken cancellationToken = default)
        {
            var basketId = new BasketId(command.BasketId);
            var basket = await _orderUnitOfWork.Set<Core.Domain.Basket.Basket>()
                                               .Include(x=>x.BasketItems)
                                               .AsNoTracking()                                                              
                                               .Where(p => Equals(p.Id, basketId))
                                               .FirstOrDefaultAsync(cancellationToken)
                                               .ConfigureAwait(false);

            if (basket == null) throw new Exception($"Basket Id {command.BasketId} not found");

            var product = await _productGrpcClient.GetProductByIdAsync(new GetProductByIdQuery { Id = command.ProductId.ToString() }, cancellationToken: cancellationToken); 
            
            if (product == null) throw new Exception($"Product Not exists { product.Name }");            
             foreach(var item in basket.BasketItems)
            {
                basket.ChangeBasketItem(product.Name, command.ProductId, command.Price, command.Quantity, product.PictureUrl, product.ProductBrand, product.ProductType);
            }         
            await _orderUnitOfWork.CommitAsync(cancellationToken);
            return await Task.FromResult(basketId.Value);
        }
    }
}

