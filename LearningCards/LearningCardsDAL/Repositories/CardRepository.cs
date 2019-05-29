using System;
using System.Collections.Generic;
using LearningCardsDAL.Entities;

namespace LearningCardsDAL.Repositories
{
    public class CardRepository:IRepository<Card>
    {
        public Card Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> Get()
        {
            throw new NotImplementedException();
        }

        public void Create(Card entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Card entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Card entity)
        {
            throw new NotImplementedException();
        }
    }
}
