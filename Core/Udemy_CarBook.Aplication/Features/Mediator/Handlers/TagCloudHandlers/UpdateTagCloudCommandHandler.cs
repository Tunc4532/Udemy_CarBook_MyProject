using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepostory<TagCloud> _repostory;
        public UpdateTagCloudCommandHandler(IRepostory<TagCloud> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.TagCloudID);
            values.Title = request.Title;
            values.BlokID = request.BlokID;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
