using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CommentCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CommentHandlers
{
    public class CreateCommandHandler : IRequestHandler<CreateCommentCommands>
    {
        private readonly IRepostory<Comment> _repostory;
        public CreateCommandHandler(IRepostory<Comment> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateCommentCommands request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Comment
            {
               Description = request.Description,
               CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
               BlokID = request.BlokID,
               Name = request.Name,
               Email = request.Email
            });
            return Unit.Value;
        }
    }
}
