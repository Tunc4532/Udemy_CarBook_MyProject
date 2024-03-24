using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.BlogInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.BlogRepositories
{
    public class BlokRepository : IBlokRepsitory
    {
        private readonly CarBookContext _context;
        public BlokRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Blok> GetAllBlogsWithAuthors()
        {
            var values = _context.Bloks.Include(x => x.Author).ToList();
            return values;
        }

        public List<Blok> GetBlogByAuthorId(int id)
        {
            var values = _context.Bloks.Include(x => x.Author).Where(y => y.BlokID == id).ToList();
            return values;
        }

        public List<Blok> GetLast3BlogsWithAuthors()
        {
            var values = _context.Bloks.Include(x => x.Author).OrderByDescending(x => x.BlokID).Take(3).ToList();
            return values;

        }
    }
}
