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
    public class RemoveTagCloudCommandHandler : IRequestHandler<RemoveTagCloudCommand>
    {
        private readonly IRepostory<TagCloud> _repostory;
        public RemoveTagCloudCommandHandler(IRepostory<TagCloud> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(values);
            return Unit.Value;
        }
    }
}
