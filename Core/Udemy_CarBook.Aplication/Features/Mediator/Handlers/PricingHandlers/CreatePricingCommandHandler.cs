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
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
    {
        private readonly IRepostory<Pricing> _repostory;
        public CreatePricingCommandHandler(IRepostory<Pricing> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Pricing
            {
                Name = request.Name
            });
            return Unit.Value; 
        }
    }
}
