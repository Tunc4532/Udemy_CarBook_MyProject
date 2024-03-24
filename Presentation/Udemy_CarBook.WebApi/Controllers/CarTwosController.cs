using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.AuthorCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CarTwoCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.AuthorQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.CarTwoQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTwosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarTwosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            var values = await _mediator.Send(new GetCarTwoQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var values = await _mediator.Send(new GetCarTwoByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateCarTwoCommand command)
        {
            await _mediator.Send(command);
            return Ok("başrı ile eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAuthor(int id)
        {
            await _mediator.Send(new RemoveCarTwoCommand(id));
            return Ok(" başarılı bir şekilde kaldırıldı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateCarTwoCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarılı Bir Şekilde Güncellendi");
        }
    }
}
