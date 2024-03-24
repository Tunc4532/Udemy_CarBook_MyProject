using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.LocationQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.RewiewQuueries;
using Udemy_CarBook.Aplication.Validators.ReviewValidators;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ReviewListByCarId(int id)
        {
            var values = await _mediator.Send(new GetReviewByCarIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand command)
        {
            CreateReviewValidator validations = new CreateReviewValidator();
            var resultva = validations.Validate(command);
            if (!resultva.IsValid)
            {
                return BadRequest(resultva);
            }
            await _mediator.Send(command);
            return Ok("Ekleme işlemi gerçekleşti");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme işlemi gerçekleşti");
        }
    }
}
