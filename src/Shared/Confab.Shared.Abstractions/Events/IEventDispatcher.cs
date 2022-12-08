using System.Threading.Tasks;

namespace Confab.Shared.Infrastructure.Events
{
    public interface IEventDispatcher
    {
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : class, IEvent;
    }
}