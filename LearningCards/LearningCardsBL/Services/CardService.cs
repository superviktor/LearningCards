using LearningCardsBL.Base;

namespace LearningCardsBL.Services
{
    public class CardService
    {
        private IRepository<Entity> _cardRepository;
        public CardService(IRepository<Entity> cardRepository)
        {
            _cardRepository = cardRepository;
        }
      
    }
}
