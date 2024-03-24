using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.CQRS.Commands.CarCommands;
using Udemy_CarBook.Aplication.Interfaces;

namespace Udemy_CarBook.Aplication.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepostory<Car> _repostory;
        public CreateCarCommandHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repostory.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                Transmission = command.Transmission,
                Seat = command.Seat,
                Model = command.Model,
                Luggage = command.Luggage,
                Km = command.Km,
                Fuel = command.Fuel,
                CoverImageUrl = command.CoverImageUrl,
                BrandID = command.BrandID
            });
        }
    }
}
