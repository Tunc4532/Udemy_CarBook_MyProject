using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.AboutDtos
{
    public class UpdateAboutDto
    {
        public int aboutID { get; set; }
        public string tittle { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
    }
}
