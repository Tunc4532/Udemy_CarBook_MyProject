using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.Mediator.Commands.CarTwoCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarTwoHandlers
{
    public class CreateCarTwoCommanHandler : IRequestHandler<CreateCarTwoCommand>
    {
        private readonly IRepostory<Car> _repostory;
        public CreateCarTwoCommanHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(CreateCarTwoCommand request, CancellationToken cancellationToken)
        {
            await _repostory.CreateAsync(new Car
            {
                BigImageUrl = request.BigImageUrl,
                Transmission = request.Transmission,
                Seat = request.Seat,
                Model = request.Model,
                Luggage = request.Luggage,
                Km = request.Km,
                Fuel = request.Fuel,
                CoverImageUrl = request.CoverImageUrl,
                BrandID = request.BrandID
            });
            return Unit.Value;
        }
    }
}
