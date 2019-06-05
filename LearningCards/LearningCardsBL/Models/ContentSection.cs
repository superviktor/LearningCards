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

        public static ContentSection Create(string content)
        {
            return new ContentSection()
            {
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
