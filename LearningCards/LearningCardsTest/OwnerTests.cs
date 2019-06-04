using System;
using System.Collections.Generic;
using System.Text;
using LearningCardsDomain.DALBase;
using LearningCardsDomain.Models;
using LearningCardsDomain.Services;
using NSubstitute;
using Xunit;

namespace LearningCardsTest
{

    public class OwnerTests
    {
        [Fact]
        public void OwnerAddDeck_CountOfDecksIncrement()
        {
            var owner = new Owner();
            var beforeAddDecksAmount = owner.Decks.Count;
            var deck = new Deck();
            owner.AddDeck(deck);
            var afterAddDecksAmount = owner.Decks.Count;
            Assert.Equal(beforeAddDecksAmount +1, afterAddDecksAmount);
        }

        [Fact]
        public void OwnerDeleteDeck_CountOfDecksDecrement()
        {
            var owner = new Owner();
            var deck = new Deck();
            owner.AddDeck(deck);
            owner.AddDeck(deck);
            owner.AddDeck(deck);
            owner.DeleteDeck(deck);
            Assert.Equal(2, owner.Decks.Count);
            
        }

    }
}
