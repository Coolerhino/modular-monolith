using System.Runtime.CompilerServices;

using System.Collections;
using System.Collections.Generic;
using Confab.Modules.Speakers.Core;
using Confab.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

[assembly:InternalsVisibleTo("ModularMonolith.Bootstrapper")]
namespace Confab.Modules.Speakers.Api
{
    internal class SpeakersModule : IModule
    {
        public const string BasePath = "speakers-module";
        public string Name { get; } = "Speakers";
        public string Path => BasePath;
        
        public IEnumerable<string> Policies { get; } = new[] { "speakers" };
        public void Register(IServiceCollection services)
        {
            services.AddCore();
        }

        public void Use(IApplicationBuilder app)
        {
        }
    }
}