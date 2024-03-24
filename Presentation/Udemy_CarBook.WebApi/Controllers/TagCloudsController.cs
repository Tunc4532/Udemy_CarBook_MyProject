using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommand;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("TagCloud alanı başrı ile eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(int id)
        {
            await _mediator.Send(new RemoveTagCloudCommand(id));
            return Ok("TagCloud alanı başarılı bir şekilde kaldırıldı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("GetTagCloudsByBlogId")]
        public async Task<IActionResult> GetTagCloudsByBlogId(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByBlogIdQuery(id));
            return Ok(values);
        }


    }
}
