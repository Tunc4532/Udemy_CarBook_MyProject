using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UdemyCarBook.Dto.CatagoryDtos;
using UdemyCarBook.Dto.FooterAdressDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminFooterAdres")]
    public class AdminFooterAdresController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminFooterAdresController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var respoonseMessage = await client.GetAsync("https://localhost:7113/api/FooterAdres");
            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAdressDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        [Route("UpdateFooterAdres/{id}")]
        public async Task<IActionResult> UpdateFooterAdres(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7113/api/FooterAdres/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFooterAdresDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateFooterAdres/{id}")]
        public async Task<IActionResult> UpdateFooterAdres(UpdateFooterAdresDto updateFooterAdresDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFooterAdresDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7113/api/FooterAdres/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooterAdres", new { area = "Admin" });
            }
            return View();
        }
    }
}
