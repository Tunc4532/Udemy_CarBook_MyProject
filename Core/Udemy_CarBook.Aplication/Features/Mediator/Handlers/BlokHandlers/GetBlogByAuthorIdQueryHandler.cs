using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.BlokQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.BlokResults;
using Udemy_CarBook.Aplication.Interfaces.BlogInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.BlokHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery,List< GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlokRepsitory _blokRepsitory;
        public GetBlogByAuthorIdQueryHandler(IBlokRepsitory blokRepsitory)
        {
            _blokRepsitory = blokRepsitory;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values = _blokRepsitory.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                AuthorID = x.AuthorID,
                BlokID = x.BlokID,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl
            }).ToList();

        }
    }
}
