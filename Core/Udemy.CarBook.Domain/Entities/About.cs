using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class About
    {
        public int AboutID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
