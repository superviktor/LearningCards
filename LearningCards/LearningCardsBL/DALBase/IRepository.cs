using System;
using System.Collections.Generic;

namespace LearningCardsBL.Base
{
    public interface IRepository<T> where T : Entity
    {
        T Get(Guid id);
        IEnumerable<T> Get();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
