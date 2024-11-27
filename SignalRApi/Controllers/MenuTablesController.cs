using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.MenuTableDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTablesController : ControllerBase
	{
		private readonly IMenuTableService _menuTableService;
		private readonly IMapper _mapper;

		public MenuTablesController(IMenuTableService menuTableService,IMapper mapper)
		{
			_menuTableService = menuTableService;
			_mapper = mapper;
		}

		[HttpGet("MenuTableCount")]
		public ActionResult MenuTableCount() 
		{ 
			return Ok(_menuTableService.TMenuTableCount());
		}

		[HttpGet]
		public IActionResult MenuTableList()
		{
            var values = _menuTableService.TGetListAll();
            return Ok(_mapper.Map<List<ResultMenuTableDto>>(values));
        }
		[HttpPost]
		public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
		{
			createMenuTableDto.Status = false;
            var value = _mapper.Map<MenuTable>(createMenuTableDto);
            _menuTableService.TAdd(value);
            return Ok("Masa Başarılı Bir Şkeilde Eklendi.");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteMenuTable(int id)
		{
			var values = _menuTableService.TGetById(id);
			_menuTableService.TDeletee(values);
			return Ok("Masa Silindi");
		}

		[HttpPut]
		public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
		{
            var value = _mapper.Map<MenuTable>(updateMenuTableDto);
            _menuTableService.TAdd(value);
            return Ok("Masa Bilgisi Güncellendi.");
		}

		[HttpGet("{id}")]
		public IActionResult GetMenuTable(int id)
		{
			var value = _menuTableService.TGetById(id);
			return Ok(_mapper.Map<GetMenuTableDto>(value));

		}
		[HttpGet("ChangeMenuTablesStatusToTrue")]
		public IActionResult ChangeMenuTablesStatusToTrue(int id)
		{
			_menuTableService.TChangeMenuTablesStatusToTrue(id);
			return Ok("İşlem Başarılı");
		}

        [HttpGet("ChangeMenuTablesStatusToFalse")]
        public IActionResult ChangeMenuTablesStatusToFalse(int id)
        {
            _menuTableService.TChangeMenuTablesStatusToFalse(id);
            return Ok("İşlem Başarılı");
        }
    }
}
