using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Results.FooterAdresResults;

namespace Udemy_CarBook.Aplication.Features.Mediator.Queries.FooterAdresQueries
{
    public class GetFooterAdresQuery : IRequest<List<GetFooterAdresQueryResult>>
    {

    }
}
