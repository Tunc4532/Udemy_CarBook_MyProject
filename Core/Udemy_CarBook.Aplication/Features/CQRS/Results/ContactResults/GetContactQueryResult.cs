using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Results.ContactResults
{
    public class GetContactQueryResult
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subjact { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
