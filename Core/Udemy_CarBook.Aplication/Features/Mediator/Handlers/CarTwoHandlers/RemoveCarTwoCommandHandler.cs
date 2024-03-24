using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CarTwoCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarTwoHandlers
{
    public class RemoveCarTwoCommandHandler : IRequestHandler<RemoveCarTwoCommand>
    {
        private readonly IRepostory<Car> _repostory;
        public RemoveCarTwoCommandHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveCarTwoCommand request, CancellationToken cancellationToken)
        {
            var value = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
