using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.BrandResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepostory<Brand> _repostory;
        public GetBrandQueryHandler(IRepostory<Brand> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                Name = x.Name
            }).ToList();
        }


    }
}
