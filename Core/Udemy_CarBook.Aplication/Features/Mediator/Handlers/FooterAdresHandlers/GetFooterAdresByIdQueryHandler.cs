using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.FooterAdresQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.FooterAdresResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.FooterAdresHandlers
{
    public class GetFooterAdresByIdQueryHandler : IRequestHandler<GetFooterAdresByIdQuery, GetFooterAdresByIdQueryResult>
    {
        private readonly IRepostory<FooterAdre> _repostory;
        public GetFooterAdresByIdQueryHandler(IRepostory<FooterAdre> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetFooterAdresByIdQueryResult> Handle(GetFooterAdresByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetFooterAdresByIdQueryResult
            {
                FooterAdreID = values.FooterAdreID,
                Adress = values.Adress,
                Description = values.Description,
                Email = values.Email,
                Phone = values.Phone,
            };
        }
    }
}
