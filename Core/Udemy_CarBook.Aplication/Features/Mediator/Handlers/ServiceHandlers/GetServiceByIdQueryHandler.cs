using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Results.AboutResults;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.PricingResults;
using Udemy_CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepostory<Service> _repostory;
        public GetServiceByIdQueryHandler(IRepostory<Service> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
               ServiceID = values.ServiceID,
               IconUrl = values.IconUrl,
               Description = values.Description,
               Tittle = values.Tittle
            };
        }
    }
}
