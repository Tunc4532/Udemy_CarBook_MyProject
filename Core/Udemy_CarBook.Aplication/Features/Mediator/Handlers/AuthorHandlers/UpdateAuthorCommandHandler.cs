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
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepostory<Author> _repostory;
        public UpdateAuthorCommandHandler(IRepostory<Author> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.AuthorID);
            values.Description = request.Description;
            values.Name = request.Name;
            values.ImageUrl = request.ImageUrl;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
