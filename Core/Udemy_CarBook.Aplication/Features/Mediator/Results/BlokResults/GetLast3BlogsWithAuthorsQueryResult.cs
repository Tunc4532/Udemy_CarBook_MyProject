using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_CarBook.Aplication.Features.Mediator.Results.BlokResults
{
    public class GetLast3BlogsWithAuthorsQueryResult
    {
        public int BlokID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CatagoryID { get; set; }
        public string AuthorName { get; set; }
    }
}
