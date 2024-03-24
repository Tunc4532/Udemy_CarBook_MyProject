using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.LocationCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.LocationHandlers
{
    public class CreateBlokCommandHandler : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepostory<Location> _repostory;
        public CreateBlokCommandHandler(IRepostory<Location> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Location
            {
                Name = request.Name
            });
            return Unit.Value;
        }
    }
}
