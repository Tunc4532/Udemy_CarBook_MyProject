using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.AppUserQueries;
using Udemy_CarBook.Aplication.Tools;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignInController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SignInController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            var values = await _mediator.Send(query);
            if (values.IsExist) 
            {
                return Created("", JwtTokenGenarator.GenareteToken(values));
            }
            else
            {
                return BadRequest("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }

    }
}
