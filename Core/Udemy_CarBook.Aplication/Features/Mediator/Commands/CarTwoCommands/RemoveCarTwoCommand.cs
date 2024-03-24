using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.CarTwoCommands
{
    public class RemoveCarTwoCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveCarTwoCommand(int id)
        {
            Id = id;
        }
    }
}
