using System.Threading.Tasks;

namespace Confab.Shared.Infrastructure.Modules
{
    public interface IModuleClient
    {
        Task PublishAsync(object message);
    }
}