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
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepostory<Pricing> _repostory;
        public UpdatePricingCommandHandler(IRepostory<Pricing> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.PricingID);
            values.Name = request.Name;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
