using Microsoft.Extensions.DependencyInjection;

//note that we omit InternalsVisibleTo
namespace Confab.Modules.Agendas.Domain
{
    public static class Extensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
            => services;
    }
}