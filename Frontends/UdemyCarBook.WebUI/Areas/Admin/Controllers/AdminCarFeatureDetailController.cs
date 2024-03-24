using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using UdemyCarBook.Dto.BannerDtos;
using UdemyCarBook.Dto.CarFeatureDtos;
using UdemyCarBook.Dto.CatagoryDtos;
using UdemyCarBook.Dto.FeatureDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCarFeatureDetail")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        [Route("Index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var respoonseMessage = await client.GetAsync($"https://localhost:7113/api/CarFeatures?id=" + id); 
            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [Route("Index/{id}")]
        public async Task<IActionResult> Index(List<ResultCarFeatureByCarIdDto> resultCarFeatureByCarIdDto)
        {
            foreach (var item in resultCarFeatureByCarIdDto)
            {
                if (item.Available)
                {
                    var client = _httpClientFactory.CreateClient();
                    await client.GetAsync($"https://localhost:7113/api/CarFeatures/CarFeatureChangeAvailabeChangeToTrue?id=" + item.CarFeatureID);
                }
                else
                {
                    var client = _httpClientFactory.CreateClient();
                    await client.GetAsync($"https://localhost:7113/api/CarFeatures/CarFeatureChangeAvailabeChangeToFalse?id=" + item.CarFeatureID);
                }
            }
            return RedirectToAction("Index", "AdminCar");
        }

        [HttpGet]
        [Route("CreateFeatureByCarId")]
        public async Task<IActionResult> CreateFeatureByCarId()
        {
            var client = _httpClientFactory.CreateClient();
            var respoonseMessage = await client.GetAsync($"https://localhost:7113/api/Features");
            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
