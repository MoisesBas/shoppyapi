using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Order.Core.Domain.Order;
using ShoppyEx.Order.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Order.Api.Features.Order.GetOrderById
{

    public sealed class GetOrderByIdQueryHandler : QueryHandler<GetOrderByIdQuery, OrderResponseModel>
    {
        private readonly IOrderUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetOrderByIdQueryHandler(
            IOrderUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public override async Task<OrderResponseModel> ExecuteQuery(GetOrderByIdQuery query, CancellationToken cancellationToken)
        {
            var OrderId = new OrderId(query.Id);
            var item = await _unitOfWork.Set<Core.Domain.Order.Order>()               
                .Include(x=>x.OrderItems)                
                .FirstOrDefaultAsync(x=>x.Id == OrderId, cancellationToken).ConfigureAwait(false);
            if(item == null) return default;            
            return _mapper.Map<OrderResponseModel>(item);
        }
    }
}
 