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
    public class GetCarCountByFuelElectiricQueryHandler : IRequestHandler<GetCarCountByFuelElectiricQuery, GetCarCountByFuelElectiricQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetCarCountByFuelElectiricQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFuelElectiricQueryResult> Handle(GetCarCountByFuelElectiricQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelElectiric();
            return new GetCarCountByFuelElectiricQueryResult
            {
                MyPropeCarCountByFuelElectiricrty = value
            };
        }
    }
}
