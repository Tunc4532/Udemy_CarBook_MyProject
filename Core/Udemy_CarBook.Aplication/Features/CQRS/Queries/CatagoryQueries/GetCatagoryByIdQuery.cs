using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Queries.CatagoryQueries
{
    public class GetCatagoryByIdQuery
    {
        public GetCatagoryByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
