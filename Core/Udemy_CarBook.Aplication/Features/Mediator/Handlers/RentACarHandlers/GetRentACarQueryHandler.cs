using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.RentACarQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.RentACarResults;
using Udemy_CarBook.Aplication.Interfaces.RentACarInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;
        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == true);
            var result = values.Select(y => new GetRentACarQueryResult
            {
                CarId = y.CarId,
                Model = y.Car.Model,
                Brand = y.Car.Brand.Name,
                CoverImageUrl = y.Car.CoverImageUrl

            }).ToList();
            return result;
        }
    }
}
