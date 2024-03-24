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
    public class RemoveAboutCommandHandler
    {
        private readonly IRepostory<About> _repostory;
        public RemoveAboutCommandHandler(IRepostory<About> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveAboutCommand command)
        {
            var value = await _repostory.GetByIdAsync(command.Id);
            await _repostory.RemoveAsync(value);
        }
    }
}
