using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.CQRS.Commands.BannerCommands
{
    public class UpdateBannerCommand
    {
        public int BannerID { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}
