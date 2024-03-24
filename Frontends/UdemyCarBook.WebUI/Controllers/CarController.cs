﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarPricingDtos;

namespace UdemyCarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Arabalar";
            ViewBag.v2 = "Kolayca Araç Kiralayın";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7113/api/CarPricings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> CarDetail(int id)
        {
            ViewBag.v1 = "Araç Deatyları";
            ViewBag.v2 = "Aracın Teknik Aksesuar ve Özellikleri";
            ViewBag.carid = id;
            return View();
        }

    }
}
