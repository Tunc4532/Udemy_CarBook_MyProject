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
    public class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommand>
    {
        private readonly IRepostory<TagCloud> _repostory;
        public CreateTagCloudCommandHandler(IRepostory<TagCloud> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new TagCloud
            {
                Title = request.Title,
                BlokID = request.BlokID,
            });
            return Unit.Value;
        }
    }
}
