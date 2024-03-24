using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
        public List<Blok> Bloks { get; set; }

    }
}
