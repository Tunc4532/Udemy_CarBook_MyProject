using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;
using Udemy_CarBook.Aplication.Interfaces.RentACarInterfaces;
using Udemy_CarBook.Persistence.Context;

namespace Udemy_CarBook.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _carBookContext;
        public RentACarRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public async Task<List<RentACar>>GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _carBookContext.RentACars.Where(filter).Include(x =>x.Car).ThenInclude(y =>y.Brand).ToListAsync();
            return values;
        }
    }
}
