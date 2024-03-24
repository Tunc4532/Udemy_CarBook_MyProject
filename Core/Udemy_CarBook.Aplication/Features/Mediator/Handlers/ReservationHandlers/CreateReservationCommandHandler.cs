using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.ReservationCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepostory<Reservatioon> _repostory;
        public CreateReservationCommandHandler(IRepostory<Reservatioon> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Reservatioon
            {
                Age = request.Age,
                CarId = request.CarId,
                Description = request.Description,
                DriverLicanseYear = request.DriverLicanseYear,
                DropOffLocationId = request.DropOffLocationId,
                Email = request.Email,
                Name = request.Name,
                Phone = request.Phone,
                PickUpLocationId = request.PickUpLocationId,
                Surname = request.Surname,
                Status = "Rezervasyon Alındı"
            });
            return Unit.Value;
        }
    }
}
