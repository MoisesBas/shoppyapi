using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Customer.Core.Domain.Customer;
using ShoppyEx.Customer.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Customer.Api.Features.Customers.GetCustomerById
{

    public sealed class GetCustomerByIdQueryHandler : QueryHandler<GetCustomerByIdQuery, CustomerModel>
    {
        private readonly ICustomerUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetCustomerByIdQueryHandler(
            ICustomerUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<CustomerModel> ExecuteQuery(GetCustomerByIdQuery query, CancellationToken cancellationToken)
        {
            var customerId = new CustomerId(query.Id);
            var item = await _unitOfWork.Set<Core.Domain.Customer.Customer>()
                .Include(x=>x.CustomerAddress)
                .Include(x=>x.ShippingAddress)
                .Include(x=>x.BillingAddress)
                .Include(x=>x.Cards)
                .FirstOrDefaultAsync(x=>x.Id == customerId, cancellationToken).ConfigureAwait(false);
            if(item == null) return default;            
            return _mapper.Map<CustomerModel>(item);
        }
    }
}
 