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
    public class UpdateContactCommandHandler
    {
        private readonly IRepostory<Contact> _repostory;
        public UpdateContactCommandHandler(IRepostory<Contact> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.ContactID);
            values.Email = command.Email;
            values.SendDate = command.SendDate;
            values.Subjact = command.Subjact;
            values.Message = command.Message;
            values.Name = command.Name;
            await _repostory.UpdateAsync(values);
        }
    }
}
