using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class Blok
    {
        public int BlokID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CatagoryID { get; set; }
        public Catagory Catagory { get; set; }
        public string Description { get; set; }
        public List<TagCloud> TagClouds { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
