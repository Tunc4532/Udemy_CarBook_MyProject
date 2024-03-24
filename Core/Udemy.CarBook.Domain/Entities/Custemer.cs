using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class Custemer
    {
        public int CustemerId { get; set; }
        public string CustemerName { get; set; }
        public string CustemerSurName { get; set; }
        public string CustemerMail { get; set; }
        public List<RentACarProcce> RentACarProcces { get; set; }
    }
}
