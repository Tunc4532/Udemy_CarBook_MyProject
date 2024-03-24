using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using Udemy_CarBook.Aplication.Interfaces.CarInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
    {
        private readonly ICarRepository _repository;
        public GetCarCountQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarCount();
            return new GetCarCountQueryResult
            {
                CarCount = values
            };
            
        }
    }
}
