using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using UdemyCarBook.Dto.LoginDtos;
using UdemyCarBook.WebUI.Models;


namespace UdemyCarBook.WebUI.Controllers
{
    public class LogInController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public LogInController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateLoginJwtDto createLoginJwtDto)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonSerializer.Serialize(createLoginJwtDto), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7113/api/SignIn", content);
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var tokenModel = JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                if (tokenModel != null)
                {
                    JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                    var token = handler.ReadJwtToken(tokenModel.Token);
                    var clims=token.Claims.ToList();
                    if(tokenModel.Token!=null)
                    {
                        clims.Add(new Claim("accessToken", tokenModel.Token));
                        var claimsIdentity = new ClaimsIdentity(clims, JwtBearerDefaults.AuthenticationScheme);
                        var autProps = new AuthenticationProperties
                        {
                            ExpiresUtc = tokenModel.ExpireDate,
                            IsPersistent = true
                        };

                        await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity),autProps);
                        return RedirectToAction("Index", "Default");
                    }
                }

            }

            return View();
        }
    }
}
