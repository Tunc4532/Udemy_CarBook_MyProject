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
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly IRepostory<Testimonial> _repostory;
        public UpdateTestimonialCommandHandler(IRepostory<Testimonial> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.TestimonialID);
            values.Tittle = request.Tittle;
            values.Comment = request.Comment;
            values.Name = request.Name;
            values.ImageUrl = request.ImageUrl;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
