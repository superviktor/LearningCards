using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LearningCardsDomain.Models
{
    public class Card
    {
        private List<ContentSection> _contentSections;
        public Card()
        {
            _contentSections = new List<ContentSection>();
        }
        public Guid Id { get;protected set; }
        public int Created { get; protected set; }
        public ReadOnlyCollection<ContentSection> ContentSections => _contentSections.AsReadOnly();

        public ContentSection AddContentSection(ContentSection contentSection)
        {
            _contentSections.Add(contentSection);
            return contentSection;
        }

        public ContentSection DeleteContentSection(ContentSection contentSection)
        {
            _contentSections.Remove(contentSection);
            return contentSection;
        }

        public ContentSection UpdateContentSection(ContentSection contentSection)
        {
            throw new NotImplementedException();
        }

        public Card Mark(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
