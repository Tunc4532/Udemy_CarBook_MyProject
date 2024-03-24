using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.ReviewDtos
{
    public class ResultReviewByCarIdDto
    {
        public int reviewID { get; set; }
        public string coustomerName { get; set; }
        public string coustomerImage { get; set; }
        public string comment { get; set; }
        public int raytingValue { get; set; }
        public DateTime reviewDate { get; set; }
        public int carID { get; set; }

    }
}
