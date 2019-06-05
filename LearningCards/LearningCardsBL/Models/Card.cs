using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LearningCardsDomain.Models
{
    public class Card
    {
        private List<ContentSection> _contentSections;

        private Card()
        {

        }
        public Guid Id { get; protected set; }
        public int Created { get; protected set; }
        public ReadOnlyCollection<ContentSection> ContentSections => _contentSections.AsReadOnly();
        public Deck Deck { get; protected set; }
        public  bool Learned { get; protected set; }

        public static Card Create(Deck deck, List<ContentSection> contentSections)
        {
            return new Card()
            {
                Deck = deck,
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

        public ContentSection UpdateContentSection(ContentSection contentSection)
        {
            var contentSectionToUpdate = _contentSections.Single(x => x.Id == contentSection.Id);
            contentSectionToUpdate.Update(contentSection.Content);
            return contentSectionToUpdate;
        }
        public Card Mark(bool learned)
        {
            Learned = learned;
            return this;
        }
    }
}
