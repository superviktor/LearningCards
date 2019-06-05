using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCardsDomain.Models
{
    public class ContentSection
    {
        private ContentSection()
        {
            
        }
        public Guid Id { get; protected set; }
        public  string Content { get; protected set; }
        public Card Card { get; protected set; }

        public static ContentSection Create(Card card, string content)
        {
            return new ContentSection()
            {
                Content = content,
                Card =  card
            };
        }

        public ContentSection Update(string content)
        {
            Content = content;
            return this;
        }
    }
}
