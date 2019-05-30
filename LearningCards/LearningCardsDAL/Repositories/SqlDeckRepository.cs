using System;
using System.Collections.Generic;
using AutoMapper;
using LearningCardsDomain.DALBase;
using LearningCardsDomain.Models;

namespace LearningCardsDAL.Repositories
{
    public class SqlDeckRepository: DeckRepository
    {
        private readonly IMapper _mapper;
        public SqlDeckRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public override IEnumerable<Deck> Get()
        {
            var testList = new List<Entities.Deck>()
            {
                new Entities.Deck()
                {
                    Id = Guid.Empty,
                    Name = "Custom deck 1"
                }
            };

            return _mapper.Map<IEnumerable<Deck>>(testList);
        }
    }
}
