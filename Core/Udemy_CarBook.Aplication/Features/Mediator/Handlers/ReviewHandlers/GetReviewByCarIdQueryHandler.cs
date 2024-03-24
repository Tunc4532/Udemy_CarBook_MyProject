using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.RewiewQuueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.ReviewResults;
using Udemy_CarBook.Aplication.Interfaces.ReviewInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.ReviewHandlers
{
    public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
    {
        private readonly IReviewRepository _repository;
        public GetReviewByCarIdQueryHandler(IReviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetReviewsByCarId(request.Id);
            return values.Select(x => new GetReviewByCarIdQueryResult
            {
                CarID = x.CarID,
                Comment = x.Comment,
                CoustomerImage = x.CoustomerImage,
                CoustomerName = x.CoustomerName,
                RaytingValue = x.RaytingValue,
                ReviewDate = x.ReviewDate,
                ReviewID = x.ReviewID
            }).ToList();
        }
    }
}
