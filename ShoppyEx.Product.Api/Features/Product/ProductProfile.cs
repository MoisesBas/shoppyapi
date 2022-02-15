using AutoMapper;

namespace ShoppyEx.Product.Api.Features.Product
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Core.Domain.Product.Product, ProductModel>()
                .ForMember(x => x.Tag, x => x.MapFrom(x => x.Tag))
                .ForMember(x=>x.Category, x=>x.MapFrom(x=>x.Category))
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                );
           
        }
    }
}
