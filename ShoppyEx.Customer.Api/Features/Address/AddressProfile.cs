using AutoMapper;
using ShoppyEx.Customer.Core.Domain.Address;

namespace ShoppyEx.Customer.Api.Features.Address
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {          

            CreateMap<CustomerAddress, AddressModel>()
                   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
                   .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId.Value));
            
        }
    }
}
