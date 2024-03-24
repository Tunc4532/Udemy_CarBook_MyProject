using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.CommentCommands
{
    public class CreateCommentCommands : IRequest
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlokID { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}