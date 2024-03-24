using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.CarResults;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.CarTwoQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.CarTwoResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarTwoHandlers
{
    public class GetCarTwoQueryHandler : IRequestHandler<GetCarTwoQuery, List<GetCarTwoQueryResult>>
    {
        private readonly IRepostory<Car> _repostory;
        public GetCarTwoQueryHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetCarTwoQueryResult>> Handle(GetCarTwoQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetCarTwoQueryResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandID = x.BrandID,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
