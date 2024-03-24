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
    public class RemoveBrandCommandHandler
    {
        private readonly IRepostory<Brand> _repostory;
        public RemoveBrandCommandHandler(IRepostory<Brand> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveBrandCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.RemoveAsync(values);
        }

    }
}
