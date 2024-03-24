using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.StatisticsResults;
using Udemy_CarBook.Aplication.Interfaces.StatisticsInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBlogTittleByMaxBlogCommentQueryHandler : IRequestHandler<GetBlogTittleByMaxBlogCommentQuery, GetBlogTittleByMaxBlogCommentQueryResult>
    {
        private readonly IStatisticsRepository _repository;
        public GetBlogTittleByMaxBlogCommentQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogTittleByMaxBlogCommentQueryResult> Handle(GetBlogTittleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogTittleByMaxBlogComment();
            return new GetBlogTittleByMaxBlogCommentQueryResult
            {
                BlogTittleByMaxBlogComment = value
            };
        }
    }
}
