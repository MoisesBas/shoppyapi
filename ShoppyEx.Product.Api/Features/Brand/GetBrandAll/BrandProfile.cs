using AutoMapper;

namespace ShoppyEx.Product.Api.Features.Brand.GetBrandAll
{
    public class BrandProfile: Profile
    {
        public BrandProfile()
        {
            CreateMap<Core.Domain.Brand.ProductBrand, BrandResponseDto>()                
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                );

        }
    }
}
