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
    public class GetFooterAdresQueryHandler : IRequestHandler<GetFooterAdresQuery, List<GetFooterAdresQueryResult>>
    {
        private readonly IRepostory<FooterAdre> _repostory;
        public GetFooterAdresQueryHandler(IRepostory<FooterAdre> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetFooterAdresQueryResult>> Handle(GetFooterAdresQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetFooterAdresQueryResult
            {
                FooterAdreID = x.FooterAdreID,
                Adress = x.Adress,
                Description = x.Description,
                Email = x.Email,
                Phone = x.Phone
            }).ToList();

        }
    }
}
