using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.FooterAdresCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.FooterAdresHandlers
{
    public class CreateFooterAdresCommandHandler : IRequestHandler<CreateFooterAdresCommand>
    {
        private readonly IRepostory<FooterAdre> _repostory;
        public CreateFooterAdresCommandHandler(IRepostory<FooterAdre> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateFooterAdresCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new FooterAdre
            {
                Adress = request.Adress,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
            return Unit.Value;
        }
    }
}
