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
    public class UpdateFooterAdresCommandHandler : IRequestHandler<UpdateFooterAdresCommand>
    {
        private readonly IRepostory<FooterAdre> _repostory;
        public UpdateFooterAdresCommandHandler(IRepostory<FooterAdre> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateFooterAdresCommand request, CancellationToken cancellationToken)
        {
            var value = await _repostory.GetByIdAsync(request.FooterAdreID);
            value.Adress = request.Adress;
            value.Phone = request.Phone;
            value.Description = request.Description;
            value.Email = request.Email;
            await _repostory.UpdateAsync(value);
            return Unit.Value;
        }
    }
}
