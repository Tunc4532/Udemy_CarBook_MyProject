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
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
    {
        private readonly IRepostory<Feature> _repostory;
        public UpdateFeatureCommandHandler(IRepostory<Feature> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.FeatureID);
            values.Name = request.Name;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
