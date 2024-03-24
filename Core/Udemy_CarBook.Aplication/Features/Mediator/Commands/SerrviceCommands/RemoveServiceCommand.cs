using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.SerrviceCommands
{
    public class RemoveServiceCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}
