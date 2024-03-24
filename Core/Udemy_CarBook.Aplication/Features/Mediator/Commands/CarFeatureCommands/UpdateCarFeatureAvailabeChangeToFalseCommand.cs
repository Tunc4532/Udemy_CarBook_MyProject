using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailabeChangeToFalseCommand : IRequest
    {
        public int Id { get; set; }
        public UpdateCarFeatureAvailabeChangeToFalseCommand(int id)
        {
            Id = id;
        }
    }
}
