using System.Collections;
using System.Collections.Generic;
using LearningCardsBL.Base;

namespace LearningCardsDAL.Entities
{
    public class Deck: Entity
    {
        public  string Name { get; set; }

        public  ICollection<Card> Cards { get; set; }
    }
}
