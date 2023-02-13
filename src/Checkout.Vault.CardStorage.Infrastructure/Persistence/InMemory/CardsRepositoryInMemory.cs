using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Aggregate;
using Checkout.Vault.CardStorage.Core.Ports;

namespace Checkout.Vault.CardStorage.Infrastructure.Persistence.InMemory;

public class CardsRepositoryInMemory : ICardsRepository
{
    public Task Save(CreateCardAggregate createCardAggregate)
    {
        //Implementation for in memory store
        DbContext.Card = createCardAggregate.Card;
        
        return Task.CompletedTask;
    }
}