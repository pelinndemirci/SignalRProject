using AutoMapper;
using SignalRDtoLayer.MenuTableDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MenuTableMapping:Profile
    {
        public MenuTableMapping() 
        {
            CreateMap<MenuTable, ResultMenuTableDto>();
            CreateMap<MenuTable, CreateMenuTableDto>();
            CreateMap<MenuTable, UpdateMenuTableDto>();
            CreateMap<MenuTable, GetMenuTableDto>();
        }
    }
}
