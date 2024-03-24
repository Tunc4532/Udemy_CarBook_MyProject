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
    public class UpdateCatagoryCommandHandler
    {
        private readonly IRepostory<Catagory> _repostory;
        public UpdateCatagoryCommandHandler(IRepostory<Catagory> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateCatagoryCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.CatagoryID);
            values.Name = command.Name;
            await _repostory.UpdateAsync(values);
        }
    }
}
