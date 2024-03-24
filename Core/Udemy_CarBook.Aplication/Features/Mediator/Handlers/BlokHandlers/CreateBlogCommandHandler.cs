using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.BlokCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.BlokHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlokCommand>
    {
        private readonly IRepostory<Blok> _repostory;
        public CreateBlogCommandHandler(IRepostory<Blok> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateBlokCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Blok
            {
                AuthorID = request.AuthorID,
                CatagoryID = request.CatagoryID,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
                Title = request.Title
            });
            return Unit.Value;
        }
    }
}
