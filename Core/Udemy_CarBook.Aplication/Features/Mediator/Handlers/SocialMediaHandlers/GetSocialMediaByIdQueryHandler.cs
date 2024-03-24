using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.SocialMediaQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.SocialMediaResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepostory<SocialMedia> _repostory;
        public GetSocialMediaByIdQueryHandler(IRepostory<SocialMedia> repostory)
        {
            _repostory = repostory;
        }

        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                SocialMediaID = values.SocialMediaID,
                Icon = values.Icon,
                Name = values.Name,
                Url = values.Url
            };
        }
    }
}
