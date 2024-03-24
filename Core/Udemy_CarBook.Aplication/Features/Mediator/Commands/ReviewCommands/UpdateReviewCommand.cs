using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Features.Mediator.Commands.ReviewCommands
{
    public class UpdateReviewCommand : IRequest
    {
        public int ReviewID { get; set; }
        public string CoustomerName { get; set; }
        public string CoustomerImage { get; set; }
        public string Comment { get; set; }
        public int RaytingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public int CarID { get; set; }
    }
}
