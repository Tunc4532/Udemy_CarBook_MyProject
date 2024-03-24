using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using Udemy_CarBook.Aplication.Features.RepositoryPattern;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _repository;
        private readonly IMediator _mediator;

        public CommentsController(IGenericRepository<Comment> repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _repository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCommand(Comment comment)
        {
            _repository.Add(comment);
            return Ok("Yorum başarıyla eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteCommand(int id)
        {
            var value = _repository.GetById(id);
            _repository.Delete(value);
            return Ok("Yorum başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateCommand(Comment comment)
        {
            _repository.Update(comment);
            return Ok("Yorum Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCommand(int id)
        {
            var values = _repository.GetById(id);
            return Ok(values);
        }

        [HttpGet("CommandListByBlog")]
        public IActionResult CommandListByBlog(int id)
        {
            var values = _repository.GetCommentsByBlogId(id);
            return Ok(values);
        }

        [HttpGet("CommentCountByBlok")]
        public IActionResult CommentCountByBlok(int id)
        {
            var values = _repository.GetCountCommentByBlog(id);
            return Ok(values);
        }

        [HttpPost("CreateCommandWithMediator")]
        public async Task<IActionResult> CreateCommandWithMediator(CreateCommentCommands command)
        {
            await _mediator.Send(command);
            return Ok("yorum başrılı bir şekilde oluşturuldu");
        }

    }
}
