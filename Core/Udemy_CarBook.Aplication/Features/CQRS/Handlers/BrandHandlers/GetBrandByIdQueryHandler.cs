using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Queries.BrandQueries;
using Udemy_CarBook.Aplication.Features.CQRS.Results.BrandResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepostory<Brand> _repostory;
        public GetBrandByIdQueryHandler(IRepostory<Brand> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repostory.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandID = values.BrandID,
                Name = values.Name
            };
        }
    }
}
