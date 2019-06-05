using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LearningCardsDomain.Models
{
    public class Owner
    {
        private List<Deck> _decks;
        private Owner()
        {
            
        }

        public Guid Id { get; set; }
        public string Email { get; protected set; }

        public static Owner Create(string email, List<Deck> decks)
        {
            return new Owner()
            {
                Email = email,
                _decks = decks ?? new List<Deck>()
            };
        }

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
