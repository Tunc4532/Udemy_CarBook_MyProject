using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.BannerCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepostory<Banner> _repostory;
        public RemoveBannerCommandHandler(IRepostory<Banner> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(RemoveBannerCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.Id);
            await _repostory.RemoveAsync(values);
        }
    }
}
