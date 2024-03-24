using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Features.RepositoryPattern;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookContext _context;
        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public void Add(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Comment comment)
        {
            var value = _context.Comments.Find(comment.CommentID);
            _context.Comments.Remove(value);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.Select(x => new Comment
            {
                CommentID = x.CommentID,
                BlokID = x.BlokID,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Name = x.Name
            }).ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id);
        }

        public List<Comment> GetCommentsByBlogId(int id)
        {
            return _context.Set<Comment>().Where(x => x.BlokID == id).ToList();
        }

        public void Update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }

        public int GetCountCommentByBlog(int id)
        {
            return _context.Comments.Where(x => x.BlokID == id).Count();
        }
    }
}
