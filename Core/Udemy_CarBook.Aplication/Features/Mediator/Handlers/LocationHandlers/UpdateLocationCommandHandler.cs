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
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepostory<Location> _repostory;
        public UpdateLocationCommandHandler(IRepostory<Location> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.LocationID);
            values.Name = request.Name;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
