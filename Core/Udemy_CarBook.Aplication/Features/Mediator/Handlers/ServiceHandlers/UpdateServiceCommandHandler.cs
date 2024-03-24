using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.SerrviceCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        private readonly IRepostory<Service> _repostory;
        public UpdateServiceCommandHandler(IRepostory<Service> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.ServiceID);
            values.Description = request.Description;
            values.Tittle = request.Tittle;
            values.IconUrl = request.IconUrl;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
