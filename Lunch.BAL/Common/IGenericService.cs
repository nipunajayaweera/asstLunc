using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch.BAL.Common
{
    public interface IGenericService<T>
    {
        void Create(T entity);
        void Delete(T entity);
        T Update(T entity);
        T GetById(int id);

        List<T> Get();
    }
}
