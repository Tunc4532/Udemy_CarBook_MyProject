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
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        private readonly IRepostory<Location> _repostory;
        public GetLocationByIdQueryHandler(IRepostory<Location> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                LocationID = values.LocationID,
                Name = values.Name
            };

        }
    }
}
