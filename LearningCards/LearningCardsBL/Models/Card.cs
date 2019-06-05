using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using LearningCardsDomain.Abstractions;

namespace LearningCardsDomain.Models
{
    public class Card : IAggregateRoot
    {
        private List<ContentSection> _contentSections;

        private Card()
        {

        }
        public Guid Id { get; protected set; }
        public int Created { get; protected set; }
        public ReadOnlyCollection<ContentSection> ContentSections => _contentSections.AsReadOnly();
        public bool Learned { get; protected set; }

        public static Card Create(List<ContentSection> contentSections)
        {
            return new Card()
            {
                Id = new Guid(),
                _contentSections = contentSections ?? new List<ContentSection>()
            };
        }

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

        public ContentSection UpdateContentSection(Guid contentSectionId, string content)
        {
            var contentSectionToUpdate = _contentSections.Single(x => x.Id == contentSectionId);
            contentSectionToUpdate.Update(content);
            return contentSectionToUpdate;
        }
        public Card Mark(bool learned)
        {
            Learned = learned;
            return this;
        }
    }
}
