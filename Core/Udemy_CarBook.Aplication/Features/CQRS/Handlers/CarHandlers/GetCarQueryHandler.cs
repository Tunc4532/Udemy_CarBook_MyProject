using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.CarResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepostory<Car> _repostory;
        public GetCarQueryHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
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
