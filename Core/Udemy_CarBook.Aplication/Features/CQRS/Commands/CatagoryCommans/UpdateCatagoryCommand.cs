using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Commands.CatagoryCommans
{
    public class UpdateCatagoryCommand
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
    }
}
