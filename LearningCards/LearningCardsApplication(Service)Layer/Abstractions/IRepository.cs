using System;
using System.Collections.Generic;
using LearningCardsDomain.Abstractions;

namespace LearningCardsApplication_Service_Layer.Abstractions
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> Get();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
