using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            //Araç sayısı
            #region İstatistik
            var respoonseMessage = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCount");

            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.v = values.carCount;
            }
            #endregion

            //lokasyon sayısı
            #region İstatistik1
            var respoonseMessage1 = await client.GetAsync("https://localhost:7113/api/Statistics/GetLocationCount");

            if (respoonseMessage1.IsSuccessStatusCode)
            {
                var jsonData1 = await respoonseMessage1.Content.ReadAsStringAsync();
                var values1 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData1);
                ViewBag.v1 = values1.locationCount;
            }
            #endregion

            //Toplam Marka Sayısı
            #region İstatistik4
            var respoonseMessage4 = await client.GetAsync("https://localhost:7113/api/Statistics/GetBrandCount");

            if (respoonseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await respoonseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData4);
                ViewBag.v4 = values4.brandCount;
            }
            #endregion

            //Elektirikli Araç Sayısı
            #region İstatistik11
            var respoonseMessage11 = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCountByFuelElectiric");

            if (respoonseMessage11.IsSuccessStatusCode)
            {
                var jsonData11 = await respoonseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData11);
                ViewBag.v11 = values11.myPropeCarCountByFuelElectiricrty;
            }
            #endregion
            return View();
        }

    }
}
