using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using LearningCardsDomain.Abstractions;

namespace LearningCardsDomain.Models
{
    public class Owner : IAggregateRoot
    {
        private List<Deck> _decks;
        private Owner()
        {

        }

        public Guid Id { get; protected set; }
        public string Email { get; protected set; }

        public static Owner Create(string email, List<Deck> decks)
        {
            return new Owner()
            {
                Id = Guid.NewGuid(),
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
