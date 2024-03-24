using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.BlokCommands
{
    public class RemoveBlokCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveBlokCommand(int id)
        {
            Id = id;
        }
    }
}
