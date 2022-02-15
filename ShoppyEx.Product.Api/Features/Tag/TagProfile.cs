using AutoMapper;

namespace ShoppyEx.Product.Api.Features.Tag
{
    public class TagProfile:Profile
    {
        public TagProfile()
        {
            CreateMap<Core.Domain.Tag.Tag, TagModel>()
                .ForMember(
                      dest => dest.Id,
                      opt => opt.MapFrom(src => src.Id.Value)
                ); 
        }
    }
}
