using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Modules.Conferences.Core.DTO;

namespace Confab.Modules.Conferences.Core.Services
{
    internal interface IHostService
    {
        Task AddAsync(HostDetailsDto dto);
        Task<HostDetailsDto> GetAsync(Guid id);
        Task<IReadOnlyList<HostDto>> BrowseAsync();
        Task UpdateAsync(HostDetailsDto dto);
        Task DeleteAsync(Guid id);
    }
}