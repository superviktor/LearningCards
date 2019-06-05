using System;
using System.Linq;
using LearningCardsDomain.Models;
using Xunit;

namespace LearningCardsTest
{
    public class DeckTests:IDisposable
    {
        private Deck _deck;
        private Card _card;
        public DeckTests()
        {
            _deck = Deck.Create("deck0", null);
            _card = Card.Create(null);
        }
        public void Dispose()
        {
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
            const string content0 = "content0";
            _deck.AddCard(_card);
            var contentSection1 = ContentSection.Create("");
            _card.AddContentSection(contentSection1);
            contentSection1.Update(content0);
            _deck.UpdateCard(_card.Id, contentSection1.Id, content0);
            Assert.Equal(content0, _deck.Cards.Single().ContentSections.Single().Content);
        }
    }
}
