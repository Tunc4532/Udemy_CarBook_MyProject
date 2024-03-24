using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.PricingCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.PricingHandlers
{
    public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommand>
    {
        private readonly IRepostory<Pricing> _repostory;
        public RemovePricingCommandHandler(IRepostory<Pricing> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemovePricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(values);
            return Unit.Value;
        }
    }
}
