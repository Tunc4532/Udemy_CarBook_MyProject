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
    public class UpdateCarCommandHandler
    {
        private readonly IRepostory<Car> _repostory;
        public UpdateCarCommandHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repostory.GetByIdAsync(command.CarID);
            values.Fuel = command.Fuel;
            values.BrandID = command.BrandID;
            values.Transmission = command.Transmission;
            values.BrandID = command.BrandID;
            values.Model = command.Model;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Km = command.Km;
            values.Seat = command.Seat;
            values.Luggage = command.Luggage;
            values.BigImageUrl = command.BigImageUrl;
            await _repostory.UpdateAsync(values);
        }
    }
}
