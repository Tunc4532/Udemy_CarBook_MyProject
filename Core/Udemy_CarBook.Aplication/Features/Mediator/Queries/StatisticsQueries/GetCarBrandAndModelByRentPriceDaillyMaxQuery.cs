using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Results.StatisticsResults;

namespace Udemy_CarBook.Aplication.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarBrandAndModelByRentPriceDaillyMaxQuery : IRequest<GetCarBrandAndModelByRentPriceDaillyMaxQueryResult>
    {
    }
}
