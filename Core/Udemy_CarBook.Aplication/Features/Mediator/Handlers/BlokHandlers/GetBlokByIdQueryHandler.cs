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

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.BlokHandlers
{
    public class GetBlokByIdQueryHandler : IRequestHandler<GetBlokByIdQuery, GetBlokByIdQueryResult>
    {
        private readonly IRepostory<Blok> _repostory;
        public GetBlokByIdQueryHandler(IRepostory<Blok> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetBlokByIdQueryResult> Handle(GetBlokByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetBlokByIdQueryResult
            {
                AuthorID = values.AuthorID,
                BlokID = values.BlokID,
                CatagoryID = values.CatagoryID,
                CoverImageUrl = values.CoverImageUrl,
                CreatedDate = values.CreatedDate,
                Title = values.Title,
                Description = values.Description,
            };

        }
    }
}
