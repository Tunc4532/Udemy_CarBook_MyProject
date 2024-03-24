using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var values = await _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }

        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var values = await _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }

        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var values = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var values = await _mediator.Send(new GetBlogCountQuery());
            return Ok(values);
        }

        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var values = await _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }

        [HttpGet("GetAvgRentPriceForDaily")]
        public async Task<IActionResult> GetAvgRentPriceForDaily()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForDailyQuery());
            return Ok(values);
        }

        [HttpGet("GetAvgRentPriceForWeekly")]
        public async Task<IActionResult> GetAvgRentPriceForWeekly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(values);
        }

        [HttpGet("GetAvgRentPriceForMounthly")]
        public async Task<IActionResult> GetAvgRentPriceForMounthly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForMounthlyQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public async Task<IActionResult> GetCarCountByTransmissionIsAuto()
        {
            var values = await _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(values);
        }

        [HttpGet("GetBrandNameByMaxCar")]
        public async Task<IActionResult> GetBrandNameByMaxCar()
        {
            var values = await _mediator.Send(new GetBrandNameByMaxCarQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogTittleByMaxBlogComment")]
        public async Task<IActionResult> GetBlogTittleByMaxBlogComment()
        {
            var values = await _mediator.Send(new GetBlogTittleByMaxBlogCommentQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByKmSmallerThen1000")]
        public async Task<IActionResult> GetCarCountByKmSmallerThen1000()
        {
            var values = await _mediator.Send(new GetCarCountByKmSmallerThen1000Query());
            return Ok(values);
        }

        [HttpGet("GetCarCountByFuelGassolineOrDiesel")]
        public async Task<IActionResult> GetCarCountByFuelGassolineOrDiesel()
        {
            var values = await _mediator.Send(new GetCarCountByFuelGassolineOrDieselQuery());
            return Ok(values);
        }

        [HttpGet("GetCarCountByFuelElectiric")]
        public async Task<IActionResult> GetCarCountByFuelElectiric()
        {
            var values = await _mediator.Send(new GetCarCountByFuelElectiricQuery());
            return Ok(values);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDaillyMax")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDaillyMax()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRentPriceDaillyMaxQuery());
            return Ok(values);
        }

        [HttpGet("GetCarBrandAndModelByRentPriceDaillyMin")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDaillyMin()
        {
            var values = await _mediator.Send(new GetCarBrandAndModelByRentPriceDaillyMinQuery());
            return Ok(values);
        }

    }
}
