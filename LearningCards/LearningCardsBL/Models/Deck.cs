using System;
using System.Collections.Generic;

namespace LearningCardsDomain.Models
{
    public class Deck
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
