using LearningCardsBL.Base;
using LearningCardsBL.Services;
using NSubstitute;
using Xunit;

namespace LearningCardsTest
{
    public class CardTests
    {
        [Fact]
        public void CardCreate()
        {
            var cardRepo = Substitute.For<IRepository<Entity>>();
            var cardService = new CardService(cardRepo);
            
        }
    }
}
