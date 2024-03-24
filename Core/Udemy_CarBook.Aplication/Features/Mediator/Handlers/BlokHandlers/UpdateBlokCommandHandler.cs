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
    public class UpdateBlokCommandHandler : IRequestHandler<UpdateBlokCommand>
    {
        private readonly IRepostory<Blok> _repostory;
        public UpdateBlokCommandHandler(IRepostory<Blok> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateBlokCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.BlokID);
            values.BlokID = request.BlokID;
            values.AuthorID = request.AuthorID;
            values.CatagoryID = request.CatagoryID;
            values.CoverImageUrl = request.CoverImageUrl;
            values.CreatedDate = request.CreatedDate;
            values.Title = request.Title;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
