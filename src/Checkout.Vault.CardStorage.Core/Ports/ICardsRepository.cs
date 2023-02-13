using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Aggregate;

namespace Checkout.Vault.CardStorage.Core.Ports;

public interface ICardsRepository
{
    Task Save(CreateCardAggregate aggregate);
}
