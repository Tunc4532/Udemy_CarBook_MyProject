using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Results.ServiceResults
{
    public class GetServiceQueryResult
    {
        public int ServiceID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
