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
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepostory<Pricing> _repostory;
        public GetPricingByIdQueryHandler(IRepostory<Pricing> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetPricingByIdQueryResult
            {
                PricingID = values.PricingID,
                Name = values.Name
            };
        }
    }
}
