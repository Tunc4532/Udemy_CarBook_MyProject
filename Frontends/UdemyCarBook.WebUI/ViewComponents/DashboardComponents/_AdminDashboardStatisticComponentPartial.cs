using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.StatisticsDtos;

namespace UdemyCarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardStatisticComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            //toplam araç sayısı
            #region İstatistik
            var respoonseMessage = await client.GetAsync("https://localhost:7113/api/Statistics/GetCarCount");

            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
                ViewBag.v = values.carCount;
            }
            #endregion

            //toplam personel sayısı
            #region İstatistik2
            var respoonseMessage2 = await client.GetAsync("https://localhost:7113/api/Statistics/GetAuthorCount");

            if (respoonseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await respoonseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData2);
                ViewBag.v2 = values2.authorCount;
            }
            #endregion

            //En Fazla Markalı araç sayısı
            #region İstatistik14
            var responseMessage14 = await client.GetAsync("https://localhost:7113/api/Statistics/GetBrandNameByMaxCar");

            if (responseMessage14.IsSuccessStatusCode)
            {
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData14);
                ViewBag.v14 = values14.brandNameByMaxCar;

            }
            #endregion

            //En Fazla yorum alan blok
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
