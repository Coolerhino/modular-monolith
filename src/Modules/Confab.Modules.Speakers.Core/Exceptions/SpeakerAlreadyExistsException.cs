using System;
using Confab.Shared.Abstractions.Exceptions;

namespace Confab.Modules.Speakers.Core.Exceptions
{
    public class SpeakerAlreadyExistsException : CustomException
    {
        public Guid Id { get; }

        public SpeakerAlreadyExistsException(Guid id) : base($"Speaker with id: '{id}' already exists.")
            => Id = id;
    }
}