using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.StatisticsInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;
        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        //yapılan yoruum sayısı
        public string GetBlogTittleByMaxBlogComment()
        {
            var values = _context.Comments.GroupBy(x => x.BlokID).
                Select(y => new
                {
                    BlokID = y.Key,
                    Count = y.Count()
                }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string blogName = _context.Bloks.Where(x => x.BlokID == values.BlokID).Select(y => y.Title).FirstOrDefault();

            return blogName;
        }

        //en fazla araçlı marka 
        public string GetBrandNameByMaxCar()
        {
            var values = _context.Cars.GroupBy(x => x.BrandID).
            Select(y => new
            {
                BrandID = y.Key,
                Count = y.Count()
            }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string brandName = _context.Brands.Where(x => x.BrandID == values.BrandID).Select(y => y.Name).FirstOrDefault();
            return brandName;
        }

        public int GetAuthorCount()
        {
            var values = _context.Authors.Count();
            return values;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            int id = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(z => z.PricingID == id).Average(w => w.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMounthly()
        {
            int id = _context.Pricings.Where(x => x.Name == "Aylık").Select(y => y.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(z => z.PricingID == id).Average(w => w.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(x => x.Name == "Haftalık").Select(y => y.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(z => z.PricingID == id).Average(w => w.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var values = _context.Bloks.Count();
            return values;
        }

        public int GetBrandCount()
        {
            var values = _context.Brands.Count();
            return values;
        }

        public string GetCarBrandAndModelByRentPriceDaillyMax()
        {
            int pricingID = _context.Pricings.Where(x => x.Name == "Saatlik").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(x => x.PricingID == pricingID).Max(y => y.Amount);
            int carID = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carID).Include(z => z.Brand).Select(y => y.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceDaillyMin()
        {
            int pricingID = _context.Pricings.Where(x => x.Name == "Saatlik").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(x => x.PricingID == pricingID).Min(y => y.Amount);
            int carID = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carID).Include(z => z.Brand).Select(y => y.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var values = _context.Cars.Count();
            return values;
        }

        public int GetCarCountByFuelElectiric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektirik").Count();
            return value;
        }

        public int GetCarCountByFuelGassolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByKmSmallerThen1000()
        {
            var value = _context.Cars.Where(x => x.Km <= 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var values = _context.Locations.Count();
            return values;
        }
    }
}
