using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using Udemy_CarBook.Aplication.Interfaces.CarFeatureInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarFeaturesHandlers
{
    public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        private readonly ICarFeatureRepository _repository;
        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            _repository.CreateFeatureByCar(new CarFeature
            {
                Available =false,
                CarID = request.CarID,
                FeatureID = request.FeatureID
            });
            return Unit.Value;
        }
    }
}
