using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.FeatureQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.FeatureResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepostory<Feature> _repostory;
        public GetFeatureByIdQueryHandler(IRepostory<Feature> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureID = values.FeatureID,
                Name = values.Name
            };

        }
    }
}
