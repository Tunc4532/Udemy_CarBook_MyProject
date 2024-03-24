using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Results.TagCloudResults
{
    public class GetTagCloudByBlogIdQueryResult
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlokID { get; set; }
    }
}
