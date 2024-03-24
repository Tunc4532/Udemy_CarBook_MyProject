using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.CarFeatureInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly CarBookContext _context;
        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }

        public  void ChangeCarFeatureAvailabeToFalse(int id)
        {
            var values =  _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
            values.Available = false;
             _context.SaveChanges();

        }

        public void ChangeCarFeatureAvailabeToTrue(int id)
        {
            var values =  _context.CarFeatures.Where(x => x.CarFeatureID == id).FirstOrDefault();
            values.Available = true;
             _context.SaveChanges();
        }

        public void CreateFeatureByCar(CarFeature carFeature)
        {
            _context.CarFeatures.Add(carFeature);
            _context.SaveChanges();
        }

        public List<CarFeature> GetCarFeaturesByCarId(int carId)
        {
            var values = _context.CarFeatures.Include(y =>y.Feature).Where(x => x.CarID== carId).ToList();
            return values;
        }
    }
}
