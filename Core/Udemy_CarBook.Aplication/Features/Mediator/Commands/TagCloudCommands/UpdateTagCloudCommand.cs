using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.TagCloudCommands
{
    public class UpdateTagCloudCommand : IRequest
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlokID { get; set; }
    }
}
