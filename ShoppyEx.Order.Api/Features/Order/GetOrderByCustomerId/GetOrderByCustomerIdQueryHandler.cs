using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Order.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;
using System.Linq;

namespace ShoppyEx.Order.Api.Features.Order.GetOrderByCustomerId
{

    public sealed class GetCustomerByIdQueryHandler : QueryHandler<GetOrderByCustomerIdQuery, IList<OrderResponseModel>>
    {
        private readonly IOrderUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetCustomerByIdQueryHandler(
            IOrderUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<IList<OrderResponseModel>> ExecuteQuery(GetOrderByCustomerIdQuery query, CancellationToken cancellationToken)
        {
           
            var item = await _unitOfWork.Set<Core.Domain.Order.Order>()
                .Include(x=>x.OrderItems)
                .AsNoTracking()               
                .Where(x=>x.CustomerId == query.CustomerId)
                .ProjectTo<OrderResponseModel>(_mapper.ConfigurationProvider)
                      .ToListAsync(cancellationToken)
                      .ConfigureAwait(false);
            if (item == null) return default;            
            return item;
        }
    }
}
 