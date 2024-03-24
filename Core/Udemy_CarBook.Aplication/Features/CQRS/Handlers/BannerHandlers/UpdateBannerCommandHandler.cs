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
    public class UpdateBannerCommandHandler
    {
        private readonly IRepostory<Banner> _repostory;
        public UpdateBannerCommandHandler(IRepostory<Banner> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateBannerCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.BannerID);
            values.VideoDescription = command.VideoDescription;
            values.Description = command.Description;
            values.VideoUrl = command.VideoUrl;
            values.Tittle = command.Tittle;
            await _repostory.UpdateAsync(values);
        }

    }
}
