using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.SocialMediaDtos;

namespace SignalRWebUI.ViewComponents.UILayoutComponents
{
	public class _UILayoutSocialMediaComponentPartial:ViewComponent
	{
	
		private readonly IHttpClientFactory _httpClientFactory;
		public _UILayoutSocialMediaComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responeseMessage = await client.GetAsync("https://localhost:7001/api/SocialMedia");
			if (responeseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responeseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
	}

