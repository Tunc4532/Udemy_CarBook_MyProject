using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Enums;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.RegisterCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepostory<AppUser> _repostory;
        public CreateAppUserCommandHandler(IRepostory<AppUser> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new AppUser
            {
                Password = request.Password,
                UserName = request.Username,
                AppRoleId = (int)RolesType.Member,
                Email = request.Email,
                Name = request.Name,
                Surname = request.Surname
            });
            return Unit.Value;
        }
    }
}
