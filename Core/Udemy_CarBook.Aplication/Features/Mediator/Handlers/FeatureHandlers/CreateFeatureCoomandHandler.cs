using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.FeatureCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.FeatureHandlers
{
    public class CreateFeatureCoomandHandler : IRequestHandler<CreateFeatureCommand>
    {
        private readonly IRepostory<Feature> _repostory;
        public CreateFeatureCoomandHandler(IRepostory<Feature> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Feature
            {
                Name = request.Name,
            });
            return Unit.Value;
        }
    }
}
