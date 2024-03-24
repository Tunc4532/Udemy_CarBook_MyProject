using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Interfaces.StatisticsInterfaces
{
    public interface IStatisticsRepository
    {
        int GetCarCount();
        int GetLocationCount();
        int GetAuthorCount();
        int GetBlogCount();
        int GetBrandCount();
        decimal GetAvgRentPriceForDaily();
        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMounthly();
        int GetCarCountByTransmissionIsAuto();
        string GetBrandNameByMaxCar();
        string GetBlogTittleByMaxBlogComment();
        int GetCarCountByKmSmallerThen1000();
        int GetCarCountByFuelGassolineOrDiesel();
        int GetCarCountByFuelElectiric();
        string GetCarBrandAndModelByRentPriceDaillyMax();
        string GetCarBrandAndModelByRentPriceDaillyMin();

    }
}
