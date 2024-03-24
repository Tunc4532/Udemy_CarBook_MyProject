using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        
        public string Name { get; set; }
        public int BlokID { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}
