using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.AppUserInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly CarBookContext _carBookContext;
        public AppUserRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
