using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using Udemy_CarBook.Aplication.Interfaces.StatisticsInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarBrandAndModelByRentPriceDaillyMinQueryHandler : IRequestHandler<GetCarBrandAndModelByRentPriceDaillyMinQuery, GetCarBrandAndModelByRentPriceDaillyMinQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCarBrandAndModelByRentPriceDaillyMinQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarBrandAndModelByRentPriceDaillyMinQueryResult> Handle(GetCarBrandAndModelByRentPriceDaillyMinQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandAndModelByRentPriceDaillyMin();
            return new GetCarBrandAndModelByRentPriceDaillyMinQueryResult
            {
                CarBrandAndModelByRentPriceDaillyMin = value
            };
        }
    }
}
