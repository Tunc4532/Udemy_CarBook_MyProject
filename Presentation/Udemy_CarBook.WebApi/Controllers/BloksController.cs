using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.BlokCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Handlers.BlokHandlers;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.BlokQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BloksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlokList()
        {
            var values = await _mediator.Send(new GetBlokQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlok(int id)
        {
            var values = await _mediator.Send(new GetBlokByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlok(CreateBlokCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blok alanı başrı ile eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBlok(int id)
        {
            await _mediator.Send(new RemoveBlokCommand(id));
            return Ok("Blok alanı başarılı bir şekilde kaldırıldı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlok(UpdateBlokCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("GetLast3BlogsWithAuthorsList")]
        public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(values);
        }
        [HttpGet("GetAllBloksWithAuthorList")]
        public async Task<IActionResult> GetAllBloksWithAuthorQueryHandler()
        {
            var values = await _mediator.Send(new GetAllBloksWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}
