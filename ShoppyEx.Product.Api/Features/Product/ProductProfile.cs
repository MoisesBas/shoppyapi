using AutoMapper;

namespace ShoppyEx.Product.Api.Features.Product
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Core.Domain.Product.Product, ProductResponseDto>()
                .ForMember(x => x.ProductBrand, x => x.MapFrom(x => x.ProductBrand.Name))
                .ForMember(x=>x.ProductType, x=>x.MapFrom(x=>x.ProductType.Name))
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                );
           
        }
    }
}
