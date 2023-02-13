namespace Checkout.Vault.CardStorage.Core.Domain;

public abstract class DomainEvent
{
    public string JsonPayload { get; set; }
    public string Type { get; set; }
}
