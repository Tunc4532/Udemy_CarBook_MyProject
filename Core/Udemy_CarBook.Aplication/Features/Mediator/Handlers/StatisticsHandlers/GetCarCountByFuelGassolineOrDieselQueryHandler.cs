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
    public class GetCarCountByFuelGassolineOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGassolineOrDieselQuery, GetCarCountByFuelGassolineOrDieselQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCarCountByFuelGassolineOrDieselQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFuelGassolineOrDieselQueryResult> Handle(GetCarCountByFuelGassolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelGassolineOrDiesel();
            return new GetCarCountByFuelGassolineOrDieselQueryResult
            {
                CarCountByFuelGassolineOrDiesel = value
            };
        }
    }
}
