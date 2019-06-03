using System;
using System.Collections.Generic;
using LearningCardsDomain.Models;

namespace LearningCardsDomain.DALBase
{
    public abstract class DeckRepository
    {
        public abstract IEnumerable<Deck> Get();

        public abstract Card AddCard(Guid deckId, Card card);

        public abstract void DeleteCard(Guid cardId);

        public abstract Deck Get(Guid deckId);
    }
}
