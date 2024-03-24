using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.LocationQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.LocationResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepostory<Location> _repostory;
        public GetLocationQueryHandler(IRepostory<Location> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x=>new GetLocationQueryResult
            {
                LocationID = x.LocationID,
                Name = x.Name
            }).ToList();
        }
    }
}
