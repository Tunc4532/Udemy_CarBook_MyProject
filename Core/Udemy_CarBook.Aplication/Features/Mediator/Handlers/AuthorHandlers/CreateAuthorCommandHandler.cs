using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.AuthorCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepostory<Author> _repostory;
        public CreateAuthorCommandHandler(IRepostory<Author> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Author
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name
            });
            return Unit.Value;
        }
    }
}
