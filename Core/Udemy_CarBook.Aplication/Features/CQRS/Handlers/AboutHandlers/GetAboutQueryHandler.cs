using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.AboutResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepostory<About> _repostory;
        public GetAboutQueryHandler(IRepostory<About> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Tittle = x.Tittle
            }).ToList();
        }

    }
}
