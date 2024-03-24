using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using UdemyCarBook.Dto.BannerDtos;
using UdemyCarBook.Dto.CatagoryDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCatagory")]
    public class AdminCatagoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminCatagoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var respoonseMessage = await client.GetAsync("https://localhost:7113/api/Catagories");
            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCatagoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        [Route("CreateCatagory")]
        public IActionResult CreateCatagory()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateCatagory")]
        public async Task<IActionResult> CreateCatagory(CreateLocationyDto createCatagoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCatagoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7113/api/Catagories", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminCatagory", new { area = "Admin" });
            }
            return View();
        }

        [Route("RemoveCatagory/{id}")]
        public async Task<IActionResult> RemoveCatagory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7113/api/Catagories?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminCatagory", new { area = "Admin" });
            }
            return View();
        }

        [HttpGet]
        [Route("UpdateCatagory/{id}")]
        public async Task<IActionResult> UpdateCatagory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7113/api/Catagories/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCatagoryDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateCatagory/{id}")]
        public async Task<IActionResult> UpdateCatagory(UpdateCatagoryDto updateCatagoryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCatagoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7113/api/Catagories/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminCatagory", new { area = "Admin" });
            }
            return View();
        }
    }
}
