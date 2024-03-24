using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.TagCloudQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.TagCloudResults;
using Udemy_CarBook.Aplication.Interfaces.TagCloudInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        private readonly ITagCloudRepository _tagCloudRepository;
        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository)
        {
            _tagCloudRepository = tagCloudRepository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _tagCloudRepository.GetTagCloudsByBlogId(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResult
            {
                BlokID = request.Id,
                TagCloudID = x.TagCloudID,
                Title = x.Title
            }).ToList();
        }
    }
}
