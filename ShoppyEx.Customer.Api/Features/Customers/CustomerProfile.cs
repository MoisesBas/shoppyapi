using AutoMapper;

namespace ShoppyEx.Customer.Api.Features.Customers
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Core.Domain.Customer.Customer, CustomerModel>()
                .ForMember(x => x.Address, x => x.MapFrom(x => x.CustomerAddress.FirstOrDefault()))
                 .ForMember(x => x.BillingAddress, x => x.MapFrom(x => x.BillingAddress.FirstOrDefault()))
                  .ForMember(x => x.ShippingAddress, x => x.MapFrom(x => x.ShippingAddress.FirstOrDefault()))
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                );
        }
    }
}
