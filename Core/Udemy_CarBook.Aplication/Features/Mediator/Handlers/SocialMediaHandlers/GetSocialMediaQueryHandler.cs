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
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepostory<SocialMedia> _repostory;
        public GetSocialMediaQueryHandler(IRepostory<SocialMedia> repostory)
        {
            _repostory = repostory;
        }

        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                SocialMediaID = x.SocialMediaID,
                Icon = x.Icon,
                Name = x.Name,
                Url = x.Url
            }).ToList();
        }
    }
}
