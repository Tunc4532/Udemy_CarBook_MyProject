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
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
    {
        private readonly IRepostory<Testimonial> _repostory;
        public RemoveTestimonialCommandHandler(IRepostory<Testimonial> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            await _repostory.RemoveAsync(values);
            return Unit.Value;
        }
    }
}
