﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Confab.Modules.Conferences.Core.DTO
{
    internal class HostDetailsDto : HostDto
    {
        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Description { get; set; }
    }
}