using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.RentACarQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RentACarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //sayfa yüklendiği anda gelecek datayı belleğe gönderme
        [HttpGet]
        public async Task<IActionResult> GetRentACarListByLocation(int locationID, bool availabe)
        {
            GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
            {
                LocationId = locationID,
                Availabe = availabe
            };

            var values =await _mediator.Send(getRentACarQuery);
            return Ok(values);
        }


    }
}
