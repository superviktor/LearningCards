using System.Collections;

namespace LearningCardsDAL.Entities
{
    public class Deck: Entity
    {
        public  string Name { get; set; }

        public  ICollection Cards { get; set; }
    }
}
