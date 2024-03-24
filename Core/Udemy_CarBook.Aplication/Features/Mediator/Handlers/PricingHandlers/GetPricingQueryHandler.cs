using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.PricingQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.PricingResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        private readonly IRepostory<Pricing> _repostory;
        public GetPricingQueryHandler(IRepostory<Pricing> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetPricingQueryResult
            {
                PricingID = x.PricingID,
                Name = x.Name
            }).ToList();
        }
    }
}
