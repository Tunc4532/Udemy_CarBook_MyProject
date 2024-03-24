using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.SocialMediaCommand;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommand>
    {
        private readonly IRepostory<SocialMedia> _repostory;
        public RemoveSocialMediaCommandHandler(IRepostory<SocialMedia> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var valus = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(valus);
            return Unit.Value;
        }
    }
}
