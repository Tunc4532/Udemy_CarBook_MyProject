using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.BlokCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.BlokHandlers
{
    public class RemoveBlokCommandHandler : IRequestHandler<RemoveBlokCommand>
    {
        private readonly IRepostory<Blok> _repostory;
        public RemoveBlokCommandHandler(IRepostory<Blok> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveBlokCommand request, CancellationToken cancellationToken)
        {
            var value = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
