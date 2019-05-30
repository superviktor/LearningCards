using System;
using System.Collections.Generic;
using LearningCardsDomain.DALBase;
using LearningCardsDomain.Models;

namespace LearningCardsDomain.Services
{
    public class DeckService
    {
        private readonly DeckRepository _deckRepository;

        public DeckService(DeckRepository deckRepository)
        {
            _deckRepository = deckRepository ?? throw new ArgumentNullException();
        }

        public IEnumerable<Deck> GetDecks()
        {
            return _deckRepository.Get();
        }
    }
}
