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
    public class RemoveCatagoryCommandHandler
    {
        private readonly IRepostory<Catagory> _repostory;
        public RemoveCatagoryCommandHandler(IRepostory<Catagory> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveCatagoryCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.RemoveAsync(values);
        }
    }
}
