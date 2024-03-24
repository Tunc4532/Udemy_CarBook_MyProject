using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Commands.AbooutCommands
{
    public class UpdateAboutCommand
    {
        public int AboutID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
