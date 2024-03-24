﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public GetContactByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}