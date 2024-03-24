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
    public class GetAllBloksWithAuthorQueryHandler : IRequestHandler<GetAllBloksWithAuthorQuery, List<GetAllBloksWithAuthorQueryResult>>
    {
        private readonly IBlokRepsitory _blokRepsitory;
        public GetAllBloksWithAuthorQueryHandler(IBlokRepsitory blokRepsitory)
        {
            _blokRepsitory = blokRepsitory;
        }

        public async Task<List<GetAllBloksWithAuthorQueryResult>> Handle(GetAllBloksWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _blokRepsitory.GetAllBlogsWithAuthors();
            return values.Select(x => new GetAllBloksWithAuthorQueryResult
            {
                AuthorID = x.AuthorID,
                BlokID = x.BlokID,
                CatagoryID = x.CatagoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                AuthorName = x.Author.Name,
                Description = x.Description,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl
            }).ToList();
        }
    }
}
