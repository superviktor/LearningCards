using System;
using LearningCardsDomain.Models;
using Xunit;

namespace LearningCardsTest
{

    public class OwnerTests: IDisposable
    {
        private Owner _owner;
        public OwnerTests()
        {
            _owner = Owner.Create("", null);
        }

        public void Dispose()
        {
            _owner = null;
        }

        [Fact]
        public void OwnerAddDeck_CountOfDecksIncrement()
        {
            var beforeAddDecksAmount = _owner.Decks.Count;
            var deck = Deck.Create("deck 01", null, _owner);
            _owner.AddDeck(deck);
            var afterAddDecksAmount = _owner.Decks.Count;
            Assert.Equal(beforeAddDecksAmount + 1, afterAddDecksAmount);
        }

        [Fact]
        public void OwnerDeleteDeck_CountOfDecksDecrement()
        {
            var deck = Deck.Create("deck 01", null, _owner);
            _owner.AddDeck(deck);
            _owner.AddDeck(deck);
            _owner.AddDeck(deck);
            _owner.DeleteDeck(deck);
            Assert.Equal(2, _owner.Decks.Count);

        }
    }
}
