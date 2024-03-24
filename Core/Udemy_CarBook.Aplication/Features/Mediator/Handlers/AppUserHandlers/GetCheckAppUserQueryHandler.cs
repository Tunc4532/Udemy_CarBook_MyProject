using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.AppUserQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.AppUserResults;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IRepostory<AppUser> _appUserrepostory;
        private readonly IRepostory<AppRole> _appRolerepostory;
        public GetCheckAppUserQueryHandler(IRepostory<AppUser> appUserrepostory, IRepostory<AppRole> appRolerepostory)
        {
            _appUserrepostory = appUserrepostory;
            _appRolerepostory = appRolerepostory;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await _appUserrepostory.GetByFilterAsync(x => x.UserName==request.UserName && x.Password==request.Password);
            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                values.IsExist= true; 
                values.UserName = user.UserName;
                values.Role = (await _appRolerepostory.GetByFilterAsync(x => x.AppRoleId == user.AppRoleId)).AppRoleName;
                values.Id = user.AppUserId;
            }
            return values;
        }
    }
}
