using System;
using System.Linq;
using LearningCardsDomain.Models;
using Xunit;

namespace LearningCardsTest
{
    public class DeckTests:IDisposable
    {
        private Owner _owner;
        private Deck _deck;
        private Card _card;
        public DeckTests()
        {
            _owner = Owner.Create("", null);
            _deck = Deck.Create("deck0", null, _owner);
            _card = Card.Create(_deck, null);
        }
        public void Dispose()
        {
            _owner = null;
            _card = null;
            _deck = null;
        }

        [Fact]
        public void DeckAddCard()
        {
            _deck.AddCard(_card);
            Assert.Single(_deck.Cards);
        }

        [Fact]
        public void DeckDeleteCard()
        {
            _deck.AddCard(_card);
            _deck.AddCard(_card);
            _deck.AddCard(_card);
            _deck.DeleteCard(_card);
            Assert.Equal(2, _deck.Cards.Count);
        }

        [Fact]
        public void DeckUpdateCard()
        {
            _card.AddContentSection(ContentSection.Create(_card, ""));
            _deck.AddCard(_card);
            const string content0 = "content0";
            _deck.UpdateCard(ContentSection.Create(_card, content0));
            Assert.Equal(content0, _deck.Cards.Single().ContentSections.Single().Content);
        }
    }
}
