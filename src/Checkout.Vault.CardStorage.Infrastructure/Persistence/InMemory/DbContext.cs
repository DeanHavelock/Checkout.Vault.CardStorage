using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Entities;

namespace Checkout.Vault.CardStorage.Infrastructure.Persistence.InMemory;

public static class DbContext
{
    public static Card Card { get; set; }
}
