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
    public class RemoveFooterAdresCommandHandler : IRequestHandler<RemoveFooterAdresCommand>
    {
        private readonly IRepostory<FooterAdre> _repostory;
        public RemoveFooterAdresCommandHandler(IRepostory<FooterAdre> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveFooterAdresCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id); 
            await _repostory.RemoveAsync(values);
            return Unit.Value;
        }
    }
}
