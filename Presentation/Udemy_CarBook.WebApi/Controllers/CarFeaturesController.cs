using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarFeaturesHandlers;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.CarFeaturesQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeatureListByCarId(int id)
        {
            var values = await _mediator.Send( new GetCarFeatureByCarIdQuery(id));
            return Ok(values);
        }

        [HttpGet("CarFeatureChangeAvailabeChangeToFalse")]
        public async Task<IActionResult> CarFeatureChangeAvailabeChangeToFalse(int id)
        {
            var values = await _mediator.Send(new UpdateCarFeatureAvailabeChangeToFalseCommand(id));
            return Ok("Güncelleme Yapıldı");
        }

        [HttpGet("CarFeatureChangeAvailabeChangeToTrue")]
        public async Task<IActionResult> CarFeatureChangeAvailabeChangeToTrue(int id)
        {
            var values = await _mediator.Send(new UpdateCarFeatureAvailabeChangeToTrueCommand(id));
            return Ok("Güncelleme Yapıldı");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarId(CreateCarFeatureByCarCommand command)
        {
            _mediator.Send(command);
            return Ok("işlem Başarılı");
        }

    }
}
