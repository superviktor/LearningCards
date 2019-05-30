using AutoMapper;
using LearningCardsDomain.Models;
using LearningCardsWebApi.Models;

namespace LearningCardsWebApi.AutoMapperProfiles
{
    public class DeckProfile:Profile
    {
        public DeckProfile()
        {
            CreateMap<DeckModel, Deck>().ReverseMap();
            CreateMap<LearningCardsDAL.Entities.Deck, Deck>().ReverseMap();
        }
    }
}
