using AutoMapper;

namespace ShoppyEx.Product.Api.Features.Type.GetProductTypedAll
{
    public class ProductTypeProfile: Profile
    {
        public ProductTypeProfile()
        {
            CreateMap<Core.Domain.Type.ProductType, ProductTypeResponseDto>()                
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                );

        }
    }
}
