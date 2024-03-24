using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.AbooutCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepostory<About> _repostory;
        public CreateAboutCommandHandler(IRepostory<About> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateAboutCommand command)
        {
            await _repostory.CreateAsync(new About
            {
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                Tittle = command.Tittle
            });
        }

    }
}
