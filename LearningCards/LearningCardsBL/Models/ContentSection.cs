using System;
using LearningCardsDomain.Abstractions;

namespace LearningCardsDomain.Models
{
    public class ContentSection : IAggregateRoot
    {
        private ContentSection()
        {

        }
        public Guid Id { get; protected set; }
        public string Content { get; protected set; }

        public static ContentSection Create(string content)
        {
            return new ContentSection()
            {
                Id = new Guid(),
                Content = content
            };
        }

        public ContentSection Update(string content)
        {
            Content = content;
            return this;
        }
    }
}
