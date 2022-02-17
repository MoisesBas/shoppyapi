using AutoMapper;

namespace ShoppyEx.Customer.Api.Features.Customers
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Core.Domain.Customer.Customer, CustomerModel>()
                .ForMember(x => x.Address, x => x.MapFrom(x => x.CustomerAddress.FirstOrDefault()))              
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                );
        }
    }
}
