using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.AuthorDtos;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            #region İstatistik
            var respoonseMessage = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCount");

            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.v = values.carCount;
            }
            #endregion

            #region İstatistik1
            var respoonseMessage1 = await client.GetAsync("https://localhost:7113/api/Statistics/GetLocationCount");

            if (respoonseMessage1.IsSuccessStatusCode)
            {
                var jsonData1 = await respoonseMessage1.Content.ReadAsStringAsync();
                var values1 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData1);
                ViewBag.v1 = values1.locationCount;
            }
            #endregion

            #region İstatistik2
            var respoonseMessage2 = await client.GetAsync("https://localhost:7113/api/Statistics/GetAuthorCount");

            if (respoonseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await respoonseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.v2 = values2.authorCount;
            }
            #endregion

            #region İstatistik3
            var respoonseMessage3 = await client.GetAsync("https://localhost:7113/api/Statistics/GetBlogCount");

            if (respoonseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await respoonseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData3);
                ViewBag.v3 = values3.blogCount;
            }
            #endregion

            #region İstatistik4
            var respoonseMessage4 = await client.GetAsync("https://localhost:7113/api/Statistics/GetBrandCount");

            if (respoonseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await respoonseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.v4 = values4.brandCount;
            }
            #endregion

            #region İstatistik5
            var respoonseMessage5 = await client.GetAsync("https://localhost:7113/api/Statistics/GetAvgRentPriceForDaily");

            if (respoonseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await respoonseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData5);
                ViewBag.v5 = values5.avgRentPriceForDaily.ToString("0,00");
            }
            #endregion
            
            #region İstatistik6
            var respoonseMessage6 = await client.GetAsync("https://localhost:7113/api/Statistics/GetAvgRentPriceForWeekly");

            if (respoonseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await respoonseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData6);
                ViewBag.v6 = values6.avgRentPriceForWeekly.ToString("0,00");
            }
            #endregion

            #region İstatistik7
            var respoonseMessage7 = await client.GetAsync("https://localhost:7113/api/Statistics/GetAvgRentPriceForMounthly");

            if (respoonseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await respoonseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData7);
                ViewBag.v7 = values7.avgRentPriceForMounthly.ToString("0,00");
            }
            #endregion

            #region İstatistik8
            var respoonseMessage8 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCountByTransmissionIsAuto");

            if (respoonseMessage8.IsSuccessStatusCode)
            {
                var jsonData8 = await respoonseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData8);
                ViewBag.v8 = values8.carCountByTransmissionIsAuto;
            }
            #endregion

            #region İstatistik9
            var respoonseMessage9 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCountByKmSmallerThen1000");

            if (respoonseMessage9.IsSuccessStatusCode)
            {
                var jsonData9 = await respoonseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData9);
                ViewBag.v9 = values9.carCountByKmSmallerThen1000;
            }
            #endregion

            #region İstatistik10
            var respoonseMessage10 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCountByFuelGassolineOrDiesel");

            if (respoonseMessage10.IsSuccessStatusCode)
            {
                var jsonData10 = await respoonseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData10);
                ViewBag.v10 = values10.carCountByFuelGassolineOrDiesel;
            }
            #endregion

            #region İstatistik11
            var respoonseMessage11 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCountByFuelElectiric");

            if (respoonseMessage11.IsSuccessStatusCode)
            {  
                var jsonData11 = await respoonseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.v11 = values11.myPropeCarCountByFuelElectiricrty;
            }
            #endregion

            #region İstatistik12
            var respoonseMessage12 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarBrandAndModelByRentPriceDaillyMax");

            if (respoonseMessage12.IsSuccessStatusCode)
            {
                var jsonData12 = await respoonseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData12);
                ViewBag.v12 = values12.carBrandAndModelByRentPriceDaillyMax;
            }
            #endregion

            #region İstatistik13
            var respoonseMessage13 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarBrandAndModelByRentPriceDaillyMin");

            if (respoonseMessage13.IsSuccessStatusCode)
            {
                var jsonData13 = await respoonseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData13);
                ViewBag.v13 = values13.carBrandAndModelByRentPriceDaillyMin;
            }
            #endregion

            #region İstatistik14
            var responseMessage14 = await client.GetAsync("https://localhost:7113/api/Statistics/GetBrandNameByMaxCar");

            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();   
                var values14 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData14);
                ViewBag.v14 = values14.brandNameByMaxCar;

            }
            #endregion

            #region İstatistik15
            var responseMessage15 = await client.GetAsync("https://localhost:7113/api/Statistics/GetBlogTittleByMaxBlogComment");

            if (responseMessage15.IsSuccessStatusCode)
            {
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData15);
                ViewBag.v15 = values15.blogTittleByMaxBlogComment;

            }
            #endregion

            return View();
        }
    }
}
