using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.FooterAdresCommands
{
    public class RemoveFooterAdresCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveFooterAdresCommand(int id)
        {
            Id = id;
        }
    }
}
