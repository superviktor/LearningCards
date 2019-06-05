using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearningCardsApplication_Service_Layer.Abstractions;
using LearningCardsDomain.Models;

namespace LearningCardsDAL.Repositories
{
    public class OwnerMemoryRepository: IRepository<Owner>
    {
        private readonly List<Owner> _owners = new List<Owner>();
        public Owner Get(Guid id)
        {
           return _owners.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Owner> Get()
        {
            throw new NotImplementedException();
        }

        public void Add(Owner entity)
        {
            _owners.Add(entity);
        }

        public void Delete(Owner entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Owner entity)
        {
            throw new NotImplementedException();
        }
    }
}
