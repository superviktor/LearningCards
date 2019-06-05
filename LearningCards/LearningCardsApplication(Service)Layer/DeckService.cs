using System;
using System.Collections.Generic;
using LearningCardsApplication_Service_Layer.Abstractions;
using LearningCardsDomain.Models;

namespace LearningCardsApplication_Service_Layer
{
    public class DeckService
    {
        private readonly IRepository<Deck> _deckRepository;
        public DeckService(IRepository<Deck> deckRepository)
        {
            _deckRepository = deckRepository;
        }

      
    }
}
