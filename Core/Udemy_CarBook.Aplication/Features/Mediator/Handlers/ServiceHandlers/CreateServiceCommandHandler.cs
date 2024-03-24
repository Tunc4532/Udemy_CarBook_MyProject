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
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepostory<Service> _repostory;
        public CreateServiceCommandHandler(IRepostory<Service> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Tittle = request.Tittle
            });
            return Unit.Value;
        }
    }
}
