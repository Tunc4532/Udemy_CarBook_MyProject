using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.CatagoryCommans;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CatagoryHandlers
{
    public class CreateCatagoryCommandHandler
    {
        private readonly IRepostory<Catagory> _repostory;
        public CreateCatagoryCommandHandler(IRepostory<Catagory> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateCatagoryCommand command)
        {
            await _repostory.CreateAsync(new Catagory
            {
                Name = command.Name,
            });
        }
    }
}
