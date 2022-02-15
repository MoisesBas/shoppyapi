using AutoMapper;

namespace ShoppyEx.Product.Api.Features.Category
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Core.Domain.Category.Category, CategoryModel>()
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                ); 
        }
    }
}
