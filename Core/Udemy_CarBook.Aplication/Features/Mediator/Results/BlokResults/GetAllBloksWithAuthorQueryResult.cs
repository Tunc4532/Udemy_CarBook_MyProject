using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Features.Mediator.Results.BlokResults
{
    public class GetAllBloksWithAuthorQueryResult
    {
        public int BlokID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
        public string CatagoryName { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CatagoryID { get; set; }
        public string Description { get; set; }
    }
}
