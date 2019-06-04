using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LearningCardsDomain.Models
{
    public class Owner
    {
        private List<Deck> _decks;
        public Owner()
        {
            _decks = new List<Deck>();
        }
        public Guid Id { get; set; }
        public string Email { get; protected set; }

        public ReadOnlyCollection<Deck> Decks => _decks.AsReadOnly();

        public Deck AddDeck(Deck deck)
        {
            _decks.Add(deck);
            return deck;
        }

        public Deck DeleteDeck(Deck deck)
        {
            _decks.Remove(deck);
            return deck;
        }
    }
}
