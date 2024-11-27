using AutoMapper;
using SignalRDtoLayer.SliderDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SliderMapping:Profile
	{
		public SliderMapping() 
		{
			CreateMap<Slider, ResultSliderDto>().ReverseMap(); 
		}
	}
}
