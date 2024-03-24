using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
    {
        private readonly IRepostory<TagCloud> _repostory;
        public GetTagCloudQueryHandler(IRepostory<TagCloud> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetTagCloudQueryResult
            {
                BlokID = x.BlokID,
                TagCloudID = x.TagCloudID,
                Title = x.Title
            }).ToList();
        }
    }
}
