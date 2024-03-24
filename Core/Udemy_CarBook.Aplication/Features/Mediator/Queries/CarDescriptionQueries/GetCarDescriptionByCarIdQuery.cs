using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Results.CarDescriptionResults;

namespace Udemy_CarBook.Aplication.Features.Mediator.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionQuery>
    {
        public int Id { get; set; }
        public GetCarDescriptionByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}
