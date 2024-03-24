using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Commands.ContactCommands
{
    public class RemoveContactCommand
    {
        public RemoveContactCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
