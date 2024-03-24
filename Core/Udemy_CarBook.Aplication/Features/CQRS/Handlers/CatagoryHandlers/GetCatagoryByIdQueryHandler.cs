using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Queries.CatagoryQueries;
using Udemy_CarBook.Aplication.Features.CQRS.Results.CatagoryResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CatagoryHandlers
{
    public class GetCatagoryByIdQueryHandler
    {
        private readonly IRepostory<Catagory> _repostory;
        public GetCatagoryByIdQueryHandler(IRepostory<Catagory> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetCatagoryByIdQueryResult> Handle(GetCatagoryByIdQuery query)
        {
            var values = await _repostory.GetByIdAsync(query.Id);
            return new GetCatagoryByIdQueryResult
            {
                Name = values.Name,
                CatagoryID = values.CatagoryID,
            };

        }
    }
}
