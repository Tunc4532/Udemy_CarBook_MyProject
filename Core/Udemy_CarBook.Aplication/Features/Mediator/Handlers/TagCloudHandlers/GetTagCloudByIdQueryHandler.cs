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
    public class GetTagCloudByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepostory<TagCloud> _repostory;
        public GetTagCloudByIdQueryHandler(IRepostory<TagCloud> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                BlokID = request.Id,
                TagCloudID = values.TagCloudID,
                Title = values.Title
            };
        }
    }
}
