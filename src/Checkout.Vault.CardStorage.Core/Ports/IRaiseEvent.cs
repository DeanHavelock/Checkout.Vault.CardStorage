using Checkout.Vault.CardStorage.Core.Domain;

namespace Checkout.Vault.CardStorage.Core.Ports;

public interface IRaiseEvent
{
    public Task Publish(DomainEvent domainEvent);
}
