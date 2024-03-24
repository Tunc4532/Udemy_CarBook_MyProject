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
    public class CreateReviewHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IRepostory<Review> _repostory;
        public CreateReviewHandler(IRepostory<Review> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Review
            {
                  CoustomerImage = request.CoustomerImage,
                  CarID = request.CarID,
                  Comment = request.Comment,
                  CoustomerName = request.CoustomerName,
                  RaytingValue = request.RaytingValue,
                  ReviewDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
            });
            return Unit.Value;
        }
    }
}
