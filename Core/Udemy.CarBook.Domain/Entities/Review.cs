using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string CoustomerName { get; set; }
        public string CoustomerImage { get; set; }
        public string Comment { get; set; }
        public int RaytingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public Car Car { get; set; }
        public int CarID { get; set; }
    }
}
