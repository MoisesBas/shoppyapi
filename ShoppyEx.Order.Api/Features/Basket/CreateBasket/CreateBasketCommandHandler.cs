using AutoMapper;
using ShoppyEx.Order.Core.Domain.Basket;
using ShoppyEx.Order.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Order.Api.Features.Basket.CreateBasket
{
    public class CreateBasketCommandHandler: CommandHandler<CreateBasketCommand, Guid>
    {
        private readonly IOrderUnitOfWork _orderUnitOfWork;
        private readonly CustomerGrpc.CustomerGrpcClient _customerGrpcClient;
        private readonly ProductGrpc.ProductGrpcClient _productGrpcClient;      

        public CreateBasketCommandHandler(IOrderUnitOfWork orderUnitOfWork, CustomerGrpc.CustomerGrpcClient customerGrpcClient,
            ProductGrpc.ProductGrpcClient productGrpcClient)
        {
            _orderUnitOfWork = orderUnitOfWork;
            _customerGrpcClient = customerGrpcClient;
            _productGrpcClient = productGrpcClient;
           
        }

        public override async Task<Guid> ExecuteCommand(CreateBasketCommand command, CancellationToken cancellationToken = default)
        {
            var customer = await _customerGrpcClient.GetCustomerByIdAsync(new CustomerByIdRequestMessage { Id = command.CustomerId.ToString() }, cancellationToken: cancellationToken);

            if (customer == null) throw new Exception($"Customer not exists {command.CustomerId}");


            var basketId = new BasketId(Guid.NewGuid());
            var basket = Core.Domain.Basket.Basket.Create(basketId, command.CustomerId);

            foreach (var item in command.Items)
            {
                var product = await _productGrpcClient.GetProductByIdAsync(new GetProductByIdQuery { Id = item.ProductId.ToString() }, cancellationToken: cancellationToken);
                if (product == null) throw new Exception($"Product Not exists {product.Name}");
                basket.AddItem(product.Name, Guid.Parse(product.Id), item.Price, item.Quantity, product.PictureUrl, product.ProductBrand, product.ProductType);
            }
            basket.TotalPrice();

            _orderUnitOfWork.Set<Core.Domain.Basket.Basket>().Add(basket);
            await _orderUnitOfWork.CommitAsync(cancellationToken);
            
            return await Task.FromResult(basketId.Value);
        }
    }
}
