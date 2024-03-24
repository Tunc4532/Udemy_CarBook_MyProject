using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.CarDescriptionQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.CarDescriptionResults;
using Udemy_CarBook.Aplication.Interfaces;
using Udemy_CarBook.Aplication.Interfaces.CarDescriptionInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQuery>
    {
        private readonly ICarDescriptionRepository _repository;
        public GetCarDescriptionQueryHandler(ICarDescriptionRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionQuery> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarDescription(request.Id);
            return new GetCarDescriptionQuery
            {
                CarDescriptionID = values.CarDescriptionID,
                CarID = values.CarID,
                Details = values.Details
            };

        }
    }
}
