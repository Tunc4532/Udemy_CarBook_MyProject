using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdemyCarBook.Dto.CarDescriptionDtos;
using UdemyCarBook.Dto.ReviewDtos;

namespace UdemyCarBook.WebUI.ViewComponents.CarDetailViewComponents
{
    public class _CarDetailCarComponentByCarIdComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CarDetailCarComponentByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.carid = id;
            var client = _httpClientFactory.CreateClient();
            var respoonseMessage = await client.GetAsync($"https://localhost:7113/api/Reviews?id=" + id);
            if (respoonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await respoonseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultReviewByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
