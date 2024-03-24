using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands;
using Udemy_CarBook.Aplication.Interfaces.CarFeatureInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarFeaturesHandlers
{
    public class UpdateCarFeatureAvailabeChangeToTrueCommandHandler : IRequestHandler<UpdateCarFeatureAvailabeChangeToTrueCommand>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;
        public UpdateCarFeatureAvailabeChangeToTrueCommandHandler(ICarFeatureRepository carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task<Unit> Handle(UpdateCarFeatureAvailabeChangeToTrueCommand request, CancellationToken cancellationToken)
        {
            _carFeatureRepository.ChangeCarFeatureAvailabeToTrue(request.Id);
            return Unit.Value;
        }
    }
}
