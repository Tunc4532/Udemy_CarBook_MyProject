using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carId);
        void ChangeCarFeatureAvailabeToFalse(int id);
        void ChangeCarFeatureAvailabeToTrue(int id);
        void CreateFeatureByCar(CarFeature carFeature);
    }
}
