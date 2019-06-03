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

    public class DeckServiceTests
    {
        [Fact]
        public void AddCard()
        {
            var repo = Substitute.For<DeckRepository>();
            var deckService = new DeckService(repo);
            deckService.AddCard(Guid.Empty);
            repo.Received().AddCard(Arg.Any<Guid>(), Arg.Any<Card>());
        }

        [Fact]
        public void DeleteCard()
        {
            var repo = Substitute.For<DeckRepository>();
            var deckService = new DeckService(repo);
            deckService.DeleteCard(Guid.Empty);
            repo.Received().DeleteCard(Arg.Any<Guid>());
        }

    }
}
