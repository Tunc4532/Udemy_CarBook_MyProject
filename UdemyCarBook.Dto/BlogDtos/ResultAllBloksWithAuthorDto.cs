using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.BlogDtos
{
    public class ResultAllBloksWithAuthorDto
    {
        public int blokID { get; set; }
        public string title { get; set; }
        public string authorName { get; set; }
        public object catagoryName { get; set; }
        public int authorID { get; set; }
        public string coverImageUrl { get; set; }
        public DateTime createdDate { get; set; }
        public int catagoryID { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
    }
}
