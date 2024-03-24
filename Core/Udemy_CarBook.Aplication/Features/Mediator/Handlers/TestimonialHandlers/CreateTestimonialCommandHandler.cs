using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.TestimonialCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IRepostory<Testimonial> _repostory;
        public CreateTestimonialCommandHandler(IRepostory<Testimonial> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Testimonial
            {
                Name = request.Name,
                Comment = request.Comment,
                ImageUrl = request.ImageUrl,
                Tittle = request.Tittle
            });
            return Unit.Value;
        }
    }
}
