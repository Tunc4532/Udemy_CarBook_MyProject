using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.AuthorQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.AuthorResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepostory<Author> _repostory;
        public GetAuthorByIdQueryHandler(IRepostory<Author> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Name = values.Name
            };
        }
    }
}
