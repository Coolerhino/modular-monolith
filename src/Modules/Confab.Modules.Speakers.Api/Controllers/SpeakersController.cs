﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Confab.Modules.Speakers.Core.DTO;
using Confab.Modules.Speakers.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Confab.Modules.Speakers.Api.Controllers
{
    internal class SpeakersController : BaseController
    {
        private readonly ISpeakersService _speakersService;

        public SpeakersController(ISpeakersService service)
        {
            _speakersService = service;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<SpeakerDto>> Get(Guid id) => OkOrNotFound(await _speakersService.GetAsync(id));

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpeakerDto>>> Get() => Ok(await _speakersService.BrowseAsync());

        [HttpPost]
        public async Task<ActionResult> Post(SpeakerDto speaker)
        {
            await _speakersService.CreateAsync(speaker);
            return CreatedAtAction(nameof(Get), new { id = speaker.Id }, null);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> Put(Guid id, SpeakerDto speaker)
        {
            speaker.Id = id;
            await _speakersService.UpdateAsync(speaker);
            return NoContent();
        }
    }
}