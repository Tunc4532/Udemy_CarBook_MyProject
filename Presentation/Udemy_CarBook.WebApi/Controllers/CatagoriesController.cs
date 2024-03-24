using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.CatagoryCommans;
using Udemy_CarBook.Aplication.Features.CQRS.Handlers.CatagoryHandlers;
using Udemy_CarBook.Aplication.Features.CQRS.Queries.CatagoryQueries;

namespace Udemy_CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private readonly CreateCatagoryCommandHandler _createCatagoryCommandHandler;
        private readonly GetCatagoryByIdQueryHandler _getCatagoryByIdQueryHandler;
        private readonly GetCatagoryQueryHandler _getCatagoryQueryHandler;
        private readonly UpdateCatagoryCommandHandler _updateCatagoryCommandHandler;
        private readonly RemoveCatagoryCommandHandler _removeCatagoryCommandHandler;

        public CatagoriesController(CreateCatagoryCommandHandler createCatagoryCommandHandler, GetCatagoryByIdQueryHandler getCatagoryByIdQueryHandler, GetCatagoryQueryHandler getCatagoryQueryHandler, UpdateCatagoryCommandHandler updateCatagoryCommandHandler, RemoveCatagoryCommandHandler removeCatagoryCommandHandler)
        {
            _createCatagoryCommandHandler = createCatagoryCommandHandler;
            _getCatagoryByIdQueryHandler = getCatagoryByIdQueryHandler;
            _getCatagoryQueryHandler = getCatagoryQueryHandler;
            _updateCatagoryCommandHandler = updateCatagoryCommandHandler;
            _removeCatagoryCommandHandler = removeCatagoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CatagoryList()
        {
            var values = await _getCatagoryQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCatagory(int id)
        {
            var values = await _getCatagoryByIdQueryHandler.Handle(new GetCatagoryByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatagory(CreateCatagoryCommand createCatagoryCommand)
        {
            await _createCatagoryCommandHandler.Handle(createCatagoryCommand);
            return Ok("Catagory Alanı Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCatagory(int id)
        {
            await _removeCatagoryCommandHandler.Handle(new RemoveCatagoryCommand(id));
            return Ok("Catagory Bilgis Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCatagory(UpdateCatagoryCommand command)
        {
            await _updateCatagoryCommandHandler.Handle(command);
            return Ok("Catagory Bilgisi Güncellendi");
        }
    }
}
