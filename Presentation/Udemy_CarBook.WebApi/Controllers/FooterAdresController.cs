using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.FooterAdresCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.FeatureQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.FooterAdresQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAdresController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FooterAdresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FooterAdresList()
        {
            var values = await _mediator.Send(new GetFooterAdresQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAdres(int id)
        {
            var values = await _mediator.Send(new GetFooterAdresByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooterAdres(CreateFooterAdresCommand command)
        {
            await _mediator.Send(command);
            return Ok("FooterAdres Başarı İle Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAdres(int id)
        {
            await _mediator.Send(new RemoveFooterAdresCommand(id));
            return Ok("FooterAdres Başarı İle Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFooterAdres(UpdateFooterAdresCommand command)
        {
            await _mediator.Send(command);
            return Ok("FooterAdres Başarı İle Güncellendi");
        }


    }
}
