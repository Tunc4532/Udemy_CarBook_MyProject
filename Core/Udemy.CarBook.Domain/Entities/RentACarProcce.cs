using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class RentACarProcce
    {
        public int RentACarProcceId { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public int PickUpLocation { get; set; }
        public int DropOffLocation { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime DropOffTime { get; set; }
        public int CustemerId { get; set; }
        public Custemer Custemer { get; set; }
        public string PickUpDescription { get; set; }
        public string DropOffDescription { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
