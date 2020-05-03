using System.Collections;
using System.Collections.Generic;
using TMoney.Models;

namespace TMoney.Repositories
{
    public interface IBaseRepository<T> where T: BaseModel
    {
        void Save(T category);
        IList<T> FindAll();
    }
}