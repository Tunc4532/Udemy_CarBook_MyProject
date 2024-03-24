using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Interfaces.BlogInterfaces
{
    public interface IBlokRepsitory
    {
        public List<Blok> GetLast3BlogsWithAuthors();
        public List<Blok> GetAllBlogsWithAuthors();
        public List<Blok> GetBlogByAuthorId(int id);
    }
}
