using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.CQRS.Results.CarResults;
using Udemy_CarBook.Aplication.Interfaces.CarInterfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;
        public GetLast5CarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetLast5CarsWithBrands();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
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
