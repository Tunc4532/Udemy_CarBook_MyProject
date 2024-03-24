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
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepostory<SocialMedia> _repostory;
        public CreateSocialMediaCommandHandler(IRepostory<SocialMedia> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new SocialMedia
            {
                Icon = request.Icon,
                Name = request.Name,
                Url = request.Url
            });
            return Unit.Value;
        }
    }
}
