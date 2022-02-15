using AutoMapper;
using ShoppyEx.Customer.Core.Domain.Address;

namespace ShoppyEx.Customer.Api.Features.Address
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
            CreateMap<BillingAddress, AddressModel>()
                .ForMember(dest => dest.Id,opt => opt.MapFrom(src => src.Id.Value))
                .ForMember(dest => dest.CustomerId,opt => opt.MapFrom(src => src.CustomerId.Value));

            CreateMap<CustomerAddress, AddressModel>()
                   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
                   .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId.Value));

            CreateMap<ShippingAddress, AddressModel>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
                  .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId.Value));
        }
    }
}
