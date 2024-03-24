using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
        public List<RentACar> RentACars { get; set; }
        public List<Reservatioon> PickUpReservation { get; set; }
        public List<Reservatioon> DropOffReservation { get; set; }
    }
}
