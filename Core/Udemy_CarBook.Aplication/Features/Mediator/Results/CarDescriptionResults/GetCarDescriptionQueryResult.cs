using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Features.Mediator.Results.CarDescriptionResults
{
    public class GetCarDescriptionQuery
    {
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public string Details { get; set; }
    }
}
