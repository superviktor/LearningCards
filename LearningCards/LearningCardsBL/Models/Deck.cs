using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LearningCardsDomain.Models
{
    public class Deck
    {
        private List<Card> _cards;

        private Deck()
        {

        }
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public ReadOnlyCollection<Card> Cards => _cards.AsReadOnly();

        public static Deck Create(string name, List<Card> cards)
        {
            return new Deck()
            {
                Name = name,
                _cards = cards ?? new List<Card>()
            };
        }

        public Deck Update(string name)
        {
            Name = name;
            return this;
        }

        public Card AddCard(Card card)
        {
            _cards.Add(card);
            return card;
        }

        public Card DeleteCard(Card card)
        {
            _cards.Remove(card);
            return card;
        }

        public Card UpdateCard(Card card)
        {
            foreach (var cs in card.ContentSections)
            {
                card.UpdateContentSection(cs);
            }
            return card;
        }
    }
}
