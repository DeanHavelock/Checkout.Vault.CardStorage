using Checkout.Vault.CardStorage.Core.Domain;
using Checkout.Vault.CardStorage.Core.Ports;

namespace Checkout.Vault.CardStorage.Infrastructure.Events.Sns;

public class SnsEventNotification : IRaiseEvent
{
    public Task Publish(DomainEvent domainEvent)
    {
        //Implementation to raise an event to aws sns here

        return Task.CompletedTask;
    }
}
