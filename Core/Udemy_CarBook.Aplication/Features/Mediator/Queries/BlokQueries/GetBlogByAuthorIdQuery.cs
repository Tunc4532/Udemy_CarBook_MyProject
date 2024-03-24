using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Results.BlokResults;

namespace Udemy_CarBook.Aplication.Features.Mediator.Queries.BlokQueries
{
    public class GetBlogByAuthorIdQuery : IRequest<List<GetBlogByAuthorIdQueryResult>>
    {
        public GetBlogByAuthorIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
