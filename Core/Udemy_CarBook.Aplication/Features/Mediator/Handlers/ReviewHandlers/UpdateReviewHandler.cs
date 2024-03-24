using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.ReviewCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.ReviewHandlers
{
    public class UpdateReviewHandler : IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepostory<Review> _repostory;
        public UpdateReviewHandler(IRepostory<Review> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.ReviewID);
            values.CoustomerName = request.CoustomerName;
            values.Comment = request.Comment;
            values.ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            values.RaytingValue = request.RaytingValue;
            values.CoustomerImage = request.CoustomerImage;
            values.CarID = request.CarID;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
