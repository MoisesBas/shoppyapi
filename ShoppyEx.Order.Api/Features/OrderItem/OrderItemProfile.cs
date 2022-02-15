using AutoMapper;

namespace ShoppyEx.Order.Api.Features.OrderItem
{
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile()
        {
            CreateMap<Core.Domain.Order.OrderItem, OrderItemResponseModel>()
                .ForMember(
                       dest => dest.OrderId,
                       opt => opt.MapFrom(src => src.OrderId.Value)
                 );
        }
    }
}
