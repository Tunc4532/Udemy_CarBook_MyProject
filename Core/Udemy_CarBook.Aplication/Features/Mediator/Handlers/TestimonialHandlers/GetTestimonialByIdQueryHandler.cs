using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.TestimonialQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.TestimonialResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly IRepostory<Testimonial> _repostory;
        public GetTestimonialByIdQueryHandler(IRepostory<Testimonial> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                Comment = values.Comment,
                TestimonialID = values.TestimonialID,
                ImageUrl = values.ImageUrl,
                Name = values.Name,
                Tittle = values.Tittle
            };
        }
    }
}
