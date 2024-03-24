using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.CarDescriptionInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepositories : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;
        public CarDescriptionRepositories(CarBookContext context)
        {
            _context = context;
        }

        public CarDescription GetCarDescription(int carId)
        {
            var values = _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefault();
            return values;
        }
    }
}
