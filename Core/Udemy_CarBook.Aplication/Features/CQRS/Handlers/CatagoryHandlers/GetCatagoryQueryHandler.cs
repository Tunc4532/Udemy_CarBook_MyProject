using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.CatagoryResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CatagoryHandlers
{
    public class GetCatagoryQueryHandler
    {
        private readonly IRepostory<Catagory> _repostory;
        public GetCatagoryQueryHandler(IRepostory<Catagory> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetCatagoryQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetCatagoryQueryResult
            {
                CatagoryID = x.CatagoryID,
                Name = x.Name,
            }).ToList();
        }
    }
}
