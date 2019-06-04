using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCardsDomain.Models
{
    public class ContentSection
    {
        public Guid Id { get; protected set; }
        public  string Content { get; protected set; }
    }
}
