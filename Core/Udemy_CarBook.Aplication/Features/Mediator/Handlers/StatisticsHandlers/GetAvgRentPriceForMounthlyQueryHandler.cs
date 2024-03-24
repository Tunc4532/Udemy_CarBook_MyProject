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
    public class GetAvgRentPriceForMounthlyQueryHandler : IRequestHandler<GetAvgRentPriceForMounthlyQuery, GetAvgRentPriceForMounthlyQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetAvgRentPriceForMounthlyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForMounthlyQueryResult> Handle(GetAvgRentPriceForMounthlyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForMounthly();
            return new GetAvgRentPriceForMounthlyQueryResult
            {
                AvgRentPriceForMounthly = value
            };
        }
    }
}
