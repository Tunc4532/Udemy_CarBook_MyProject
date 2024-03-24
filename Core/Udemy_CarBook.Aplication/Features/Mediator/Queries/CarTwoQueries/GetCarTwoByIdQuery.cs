using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Results.CarTwoResults;

namespace Udemy_CarBook.Aplication.Features.Mediator.Queries.CarTwoQueries
{
    public class GetCarTwoByIdQuery : IRequest<GetCarTwoByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCarTwoByIdQuery(int id)
        {
            Id = id;
        }
    }
}
