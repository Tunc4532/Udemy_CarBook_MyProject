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
    public class CreateBannerCommandHandler
    {
        private readonly IRepostory<Banner> _repostory;
        public CreateBannerCommandHandler(IRepostory<Banner> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            await _repostory.CreateAsync(new Banner
            {
                Description = command.Description,
                Tittle = command.Tittle,
                VideoDescription = command.VideoDescription,
                VideoUrl = command.VideoUrl
            });

        }
    }
}
