using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.BrandCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepostory<Brand> _repostory;
        public UpdateBrandCommandHandler(IRepostory<Brand> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateBrandCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.BrandID);
            values.Name = command.Name;
            await _repostory.UpdateAsync(values);
        }
    }
}
