using System.Collections.Generic;
using LearningCardsBL.Base;

namespace LearningCardsBL.Models
{
    public class Card:Entity
    {
        public int Number { get; set; }

        public Deck Deck { get; set; }

        public ICollection<ContentSection> ContentSections { get; set; }
    }
}
