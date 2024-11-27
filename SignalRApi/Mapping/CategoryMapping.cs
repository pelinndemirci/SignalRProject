using AutoMapper;
using SignalRDtoLayer.AboutDto;
using SignalRDtoLayer.CategoryDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
