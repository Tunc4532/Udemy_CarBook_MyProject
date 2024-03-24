using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly IRepostory<Car> _repostory;
        public RemoveCarCommandHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveCarCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.RemoveAsync(values);
        }
    }
}
