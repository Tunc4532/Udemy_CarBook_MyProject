using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Queries.CarQueries;
using Udemy_CarBook.Aplication.Features.CQRS.Results.CarResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepostory<Car> _repostory;
        public GetCarByIdQueryHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repostory.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
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
