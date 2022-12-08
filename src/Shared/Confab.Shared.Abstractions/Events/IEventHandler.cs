using System.Threading.Tasks;

namespace Confab.Shared.Infrastructure.Events
{
    public interface IEventHandler<in TEvent> where TEvent : class, IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}