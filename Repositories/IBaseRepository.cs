using System.Collections;
using System.Collections.Generic;
using t_money.Models;

namespace t_money.Repositories
{
    public interface IBaseRepository<T> where T: BaseModel
    {
        void Save(T category);
        IList<T> FindAll();
    }
}