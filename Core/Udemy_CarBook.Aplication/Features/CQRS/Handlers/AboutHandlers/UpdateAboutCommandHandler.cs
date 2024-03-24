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
    public class UpdateAboutCommandHandler
    {
        private readonly IRepostory<About> _repostory;
        public UpdateAboutCommandHandler(IRepostory<About> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateAboutCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.AboutID);
            values.Description = command.Description;
            values.Tittle = command.Tittle;
            values.ImageUrl = command.ImageUrl;
            await _repostory.UpdateAsync(values);
        }
    }
}
