using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Interfaces.ReviewInterfaces
{
    public interface IReviewRepository
    {
        public List<Review> GetReviewsByCarId(int carId);
    }
}
