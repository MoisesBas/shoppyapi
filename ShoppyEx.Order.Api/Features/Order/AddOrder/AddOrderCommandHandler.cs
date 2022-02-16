using ShoppyEx.Order.Core.Domain.Order;
using ShoppyEx.Order.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Order.Api.Features.Order.AddOrder
{

    public sealed class AddOrderCommandHandler : CommandHandler<AddOrderCommand, Guid>
    {
        private readonly IOrderUnitOfWork _unitOfWork;
        public AddOrderCommandHandler(IOrderUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override async Task<Guid> ExecuteCommand(AddOrderCommand command,
            CancellationToken cancellationToken)
        {
            try
            {

                //var orderId = new OrderId(Guid.NewGuid());
                //var order = Core.Domain.Order.Order.Create(orderId, command.CustomerId, command.CreditCard, command.CreditCardTypeID,
                //    command.CardExpMo, command.CardExpYr, new Address()
                //    {
                //        Address = command.Address,
                //        City = command.City,
                //        Country = command.Country,
                //        PostalCode = command.PostalCode,
                //        Region = command.Region
                //    });

                //foreach (var item in command.OrderItems)
                //{
                //    order.AddOrderItems(item.ProductId, item.Price, item.Quantity);
                //}

                //await _unitOfWork.Set<Core.Domain.Order.Order>()
                //                 .AddAsync(order, cancellationToken);

                //await _unitOfWork.CommitAsync(cancellationToken);

                //return await Task.FromResult(order.Id.Value);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
