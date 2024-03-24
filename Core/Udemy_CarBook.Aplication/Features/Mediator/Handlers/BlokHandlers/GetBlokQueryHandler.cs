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
    public class GetBlokQueryHandler : IRequestHandler<GetBlokQuery, List<GetBlokByIdQueryResult>>
    {
        private readonly IRepostory<Blok> _repostory;
        public GetBlokQueryHandler(IRepostory<Blok> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetBlokByIdQueryResult>> Handle(GetBlokQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetBlokByIdQueryResult
            {
                AuthorID = x.AuthorID,
                BlokID = x.BlokID,
                CatagoryID = x.CatagoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title
            }).ToList();

        }
    }
}
