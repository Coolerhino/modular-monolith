﻿using System;
using System.Collections.Generic;
using Confab.Modules.Agendas.Application.Submissions.DTO;

namespace Confab.Modules.Agendas.Application.Agendas.DTO
{
    public class AgendaItemDto
    {
        public Guid Id { get; set; }
        public Guid ConferenceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<SpeakerDto> Speakers { get; set; }
    }
}