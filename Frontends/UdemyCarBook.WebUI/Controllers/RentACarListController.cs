using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using UdemyCarBook.Dto.BrandDtos;
using UdemyCarBook.Dto.RentACarDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public RentACarListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            //var book_pick_date = TempData["book_pick_date"];
            //var book_off_date = TempData["book_off_date"];
            //var time_pick = TempData["time_pick"];
            //var time_off = TempData["time_off"];

            //locationıd default controller tarafından temp data ile taşındı
            var locationID = TempData["locationID"];

            id = int.Parse(locationID.ToString());

            //ViewBag.book_pick_date = book_pick_date;
            //ViewBag.book_off_date = book_off_date;
            //ViewBag.time_pick = time_pick;
            //ViewBag.time_off = time_off;
            ViewBag.locationID = locationID;


            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7113/api/RentACars?locationID={id}&availabe=true");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FilterRentACarDto>>(jsonData);
                return View(values);
            }

            return View();
        }

    }
}
