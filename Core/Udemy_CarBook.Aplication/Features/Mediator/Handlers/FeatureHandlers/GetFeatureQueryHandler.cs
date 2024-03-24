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
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        private readonly IRepostory<Feature> _repostory;
        public GetFeatureQueryHandler(IRepostory<Feature> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResult
            {
                FeatureID = x.FeatureID,
                Name = x.Name
            }).ToList();

        }
    }
}
