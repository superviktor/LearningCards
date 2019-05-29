namespace LearningCardsDAL.Entities
{
    public class ContentSection:Entity
    {
        public Card Card { get; set; }
        public string Content { get; set; }
    }
}
