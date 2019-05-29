using System.Collections.Generic;
using LearningCardsBL.Base;

namespace LearningCardsBL.Models
{
    public class Deck:Entity
    {
        public string Name { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}
