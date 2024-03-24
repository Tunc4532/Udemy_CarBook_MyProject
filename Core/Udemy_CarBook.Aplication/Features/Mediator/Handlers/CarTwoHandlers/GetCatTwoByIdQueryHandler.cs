using MediatR;
using System;
using System.Collections;
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
    public class GetCatTwoByIdQueryHandler : IRequestHandler<GetCarTwoByIdQuery, GetCarTwoByIdQueryResult>
    {
        private readonly IRepostory<Car> _repostory;
        public GetCatTwoByIdQueryHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetCarTwoByIdQueryResult> Handle(GetCarTwoByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetCarTwoByIdQueryResult
            {
                BigImageUrl = values.BigImageUrl,
                Transmission = values.Transmission,
                Seat = values.Seat,
                Model = values.Model,
                Luggage = values.Luggage,
                Km = values.Km,
                Fuel = values.Fuel,
                CoverImageUrl = values.CoverImageUrl,
                CarID = values.CarID,
                BrandID = values.BrandID
            };
        }
    }
}
