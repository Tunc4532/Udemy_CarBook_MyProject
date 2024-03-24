using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.StatisticsDtos
{
    public class ResultStatisticDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgRentPriceForDaily { get; set; }
        public decimal avgRentPriceForWeekly { get; set; }
        public decimal avgRentPriceForMounthly { get; set; }
        public int carCountByTransmissionIsAuto { get; set; }
        public int carCountByKmSmallerThen1000 { get; set; }
        public int carCountByFuelGassolineOrDiesel { get; set; }
        public int myPropeCarCountByFuelElectiricrty { get; set; }
        public string? carBrandAndModelByRentPriceDaillyMax { get; set; }
        public string? carBrandAndModelByRentPriceDaillyMin { get; set; }
        public string? brandNameByMaxCar { get; set; }
        public string? blogTittleByMaxBlogComment { get; set; }

    }
}
