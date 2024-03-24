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
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly IRepostory<Author> _repostory;
        public RemoveAuthorCommandHandler(IRepostory<Author> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(value);
            return Unit.Value;
        }
    }
}
