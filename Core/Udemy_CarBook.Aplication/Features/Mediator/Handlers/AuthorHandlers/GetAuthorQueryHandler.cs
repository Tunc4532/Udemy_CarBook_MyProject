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
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        private readonly IRepostory<Author> _repostory;
        public GetAuthorQueryHandler(IRepostory<Author> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name
            }).ToList();

        }
    }
}
