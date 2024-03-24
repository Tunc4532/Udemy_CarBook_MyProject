using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.BannerResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepostory<Banner> _repostory;
        public GetBannerQueryHandler(IRepostory<Banner> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                BannerID = x.BannerID,
                Description = x.Description,
                Tittle = x.Tittle,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();
        }
    }
}
