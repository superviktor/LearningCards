using System.Collections.Generic;
using LearningCardsDomain.Models;

namespace LearningCardsDomain.DALBase
{
    public abstract class DeckRepository
    {
        public abstract IEnumerable<Deck> Get();
    }
}
