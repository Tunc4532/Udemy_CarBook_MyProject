using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.ContactCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.ContactHandlers
{
    public class RemoveContactCommandHandler
    {
        private readonly IRepostory<Contact> _repostory;
        public RemoveContactCommandHandler(IRepostory<Contact> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveContactCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.RemoveAsync(values);        
        }
    }
}
