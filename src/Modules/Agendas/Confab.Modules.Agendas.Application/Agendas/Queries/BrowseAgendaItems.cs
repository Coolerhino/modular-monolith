using System;
using System.Collections.Generic;
using Confab.Modules.Agendas.Application.Agendas.DTO;
using Confab.Shared.Abstractions.Queries;

namespace Confab.Modules.Agendas.Application.Agendas.Queries
{
    public class BrowseAgendaItems : IQuery<IEnumerable<AgendaItemDto>>
    {
        public Guid ConferenceId { get; set; }
    }
    public class GetAgenda : IQuery<IEnumerable<AgendaTrackDto>>
    {
        public Guid ConferenceId { get; set; }
    }
    public class GetAgendaItem : IQuery<AgendaItemDto>
    {
        public Guid Id { get; set; }
    }
    public class GetAgendaTrack : IQuery<AgendaTrackDto>
    {
        public Guid Id { get; set; }
    }
    public class GetRegularAgendaSlot : IQuery<RegularAgendaSlotDto>
    {
        public Guid AgendaItemId { get; set; }
    }
}