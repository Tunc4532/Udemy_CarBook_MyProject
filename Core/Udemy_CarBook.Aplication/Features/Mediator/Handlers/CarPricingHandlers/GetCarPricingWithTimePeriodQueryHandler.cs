using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy_CarBook.Aplication.Features.Mediator.Queries.CarPricingQueries;
using Udemy_CarBook.Aplication.Features.Mediator.Results.CarPricingResult;
using Udemy_CarBook.Aplication.Interfaces.CarPricingInterfaces;

namespace Udemy_CarBook.Aplication.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
	{
		private readonly ICarPricingRepository _repository;
		public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository)
		{
			_repository = repository;
		}

		public Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		//public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
		//{
		//	var values = _repository.GetCarPricingWithTimePeriod1();
		//	return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
		//	{
		//		Brand = x.Brand,
		//		Model = x.Model,
		//		CoverImageUrl = x.CoverImageUrl,
		//		DailyAmount = x.Amounts[0],
		//		WeeklyAmount = x.Amounts[1],
		//		MonthlyAmount = x.Amounts[2]
		//	}).ToList();
		//}
	}
}
