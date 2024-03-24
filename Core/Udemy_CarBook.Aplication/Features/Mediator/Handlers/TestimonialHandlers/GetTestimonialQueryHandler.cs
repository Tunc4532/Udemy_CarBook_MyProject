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
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly IRepostory<Testimonial> _repostory;
        public GetTestimonialQueryHandler(IRepostory<Testimonial> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                TestimonialID = x.TestimonialID,
                Comment = x.Comment,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Tittle = x.Tittle
            }).ToList();
        }
    }
}
