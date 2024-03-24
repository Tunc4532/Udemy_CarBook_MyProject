using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.ServiceQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.PricingResults;
using Udemy_CarBook.Aplication.Features.Mediator.Results.ServiceResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepostory<Service> _repostory;
        public GetServiceQueryHandler(IRepostory<Service> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceID = x.ServiceID,
                Description = x.Description,
                IconUrl = x.IconUrl,
                Tittle = x.Tittle
            }).ToList();
        }
    }
}
