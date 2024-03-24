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
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepostory<SocialMedia> _repostory;
        public UpdateSocialMediaCommandHandler(IRepostory<SocialMedia> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.SocialMediaID);
            values.SocialMediaID = request.SocialMediaID;
            values.Url = request.Url;
            values.Name = request.Name;
            values.Icon = request.Icon;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
