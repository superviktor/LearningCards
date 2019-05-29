using LearningCardsBL.Base;

namespace LearningCardsBL.Models
{
    public class ContentSection:Entity
    {
        public Card Card { get; set; }
        public string Content { get; set; }
    }
}
