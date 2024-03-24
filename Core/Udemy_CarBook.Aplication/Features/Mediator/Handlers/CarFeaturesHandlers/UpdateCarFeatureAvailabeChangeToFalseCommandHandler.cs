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
    public class UpdateCarFeatureAvailabeChangeToFalseCommandHandler : IRequestHandler<UpdateCarFeatureAvailabeChangeToFalseCommand>
    {
        private readonly ICarFeatureRepository _carFeatureRepository;
        public UpdateCarFeatureAvailabeChangeToFalseCommandHandler(ICarFeatureRepository carFeatureRepository)
        {
            _carFeatureRepository = carFeatureRepository;
        }

        public async Task<Unit> Handle(UpdateCarFeatureAvailabeChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            _carFeatureRepository.ChangeCarFeatureAvailabeToFalse(request.Id);
            return Unit.Value;
        }
    }
}
