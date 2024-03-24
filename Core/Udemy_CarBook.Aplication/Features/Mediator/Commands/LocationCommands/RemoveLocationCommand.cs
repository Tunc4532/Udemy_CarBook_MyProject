﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.LocationCommands
{
    public class RemoveLocationCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveLocationCommand(int id)
        {
            Id = id;
        }
    }
}