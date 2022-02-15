using AutoMapper;

namespace ShoppyEx.Order.Api.Features.Order
{
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile()
        {
            CreateMap<Core.Domain.Order.Order, OrderResponseModel>()
                 .ForMember(x => x.OrderItems, x => x.MapFrom(x => x.OrderItems))                 
                 .ForMember(
                       dest => dest.Id,
                       opt => opt.MapFrom(src => src.Id.Value)
                 );

        }
    }
}
