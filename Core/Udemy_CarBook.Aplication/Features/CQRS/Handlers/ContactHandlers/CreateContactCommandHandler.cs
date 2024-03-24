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
    public class CreateContactCommandHandler
    {
        private readonly IRepostory<Contact> _repostory;
        public CreateContactCommandHandler(IRepostory<Contact> repostory)
        {
            _repostory = repostory;
        }


        public async Task Handle(CreateContactCommand command)
        {
            await _repostory.CreateAsync(new Contact
            {
                Email = command.Email,
                Message = command.Message,
                Name = command.Name,
                SendDate = command.SendDate,
                Subjact = command.Subjact
            });
        }




    }
}
