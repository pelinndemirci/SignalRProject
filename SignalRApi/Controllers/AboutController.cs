using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController:ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(_mapper.Map<List<ResultAboutDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {

            var value = _mapper.Map<About>(createAboutDto);
            _aboutService.TAdd(value);
            return Ok("Hakkımda Kısmı Başarılı Bir Şkeilde Eklendi.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById (id);
            _aboutService.TDeletee(values);
            return Ok("Hakkımda Alanı Silindi");
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("Hakkımda Alanı Güncellendi.");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id) {
            
           var value = _aboutService.TGetById(id);
            return Ok(_mapper.Map<GetAboutDto>(value));

        }
    }
}
