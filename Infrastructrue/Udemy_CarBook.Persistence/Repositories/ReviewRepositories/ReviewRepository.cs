using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.ReviewInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.ReviewRepositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly CarBookContext _carBookContext;
        public ReviewRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public List<Review> GetReviewsByCarId(int carId)
        {
            var values = _carBookContext.Reviews.Where(x => x.CarID == carId).ToList();
            return values;
        }
    }
}
