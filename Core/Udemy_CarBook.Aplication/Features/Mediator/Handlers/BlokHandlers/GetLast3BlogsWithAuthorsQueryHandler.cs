using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.BlokQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.BlokResults;
using Udemy_CarBook.Aplication.Interfaces;
using Udemy_CarBook.Aplication.Interfaces.BlogInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.BlokHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlokRepsitory _repsitory;
        public GetLast3BlogsWithAuthorsQueryHandler(IBlokRepsitory repsitory)
        {
            _repsitory = repsitory;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repsitory.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                AuthorID = x.AuthorID,
                BlokID = x.BlokID,
                CatagoryID = x.CatagoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                AuthorName = x.Author.Name
            }).ToList();
        }
    }
}
