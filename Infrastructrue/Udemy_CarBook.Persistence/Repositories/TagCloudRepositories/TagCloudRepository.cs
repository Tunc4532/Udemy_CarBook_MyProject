using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.TagCloudInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly CarBookContext _context;
        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudsByBlogId(int id)
        {
            var values = _context.TagClouds.Where(x =>x.BlokID == id).ToList();
            return values;
        }
    }
}
