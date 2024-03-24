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
    public class UpdateCarTwoCommandHandler : IRequestHandler<UpdateCarTwoCommand>
    {
        private readonly IRepostory<Car> _repostory;
        public UpdateCarTwoCommandHandler(IRepostory<Car> repostory)
        {
            _repostory = repostory;
        }

        public async Task<Unit> Handle(UpdateCarTwoCommand request, CancellationToken cancellationToken)
        {
            var values = await _repostory.GetByIdAsync(request.CarID);
            values.Fuel = request.Fuel;
            values.BrandID = request.BrandID;
            values.Transmission = request.Transmission;
            values.BrandID = request.BrandID;
            values.Model = request.Model;
            values.CoverImageUrl = request.CoverImageUrl;
            values.Km = request.Km;
            values.Seat = request.Seat;
            values.Luggage = request.Luggage;
            values.BigImageUrl = request.BigImageUrl;
            await _repostory.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
