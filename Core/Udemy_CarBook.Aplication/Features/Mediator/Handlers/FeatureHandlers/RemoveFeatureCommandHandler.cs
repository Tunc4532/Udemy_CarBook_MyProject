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
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommand>
    {
        private readonly IRepostory<Feature> _repostory;
        public RemoveFeatureCommandHandler(IRepostory<Feature> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
