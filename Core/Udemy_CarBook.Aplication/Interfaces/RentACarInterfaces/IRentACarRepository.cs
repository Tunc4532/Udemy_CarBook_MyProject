using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Udemy.CarBook.Domain.Entities;

namespace Udemy_CarBook.Aplication.Interfaces.RentACarInterfaces
{
    public interface IRentACarRepository
    {
       Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);

    }
}
