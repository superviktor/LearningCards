using System;

namespace LearningCardsDomain.Abstractions
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
