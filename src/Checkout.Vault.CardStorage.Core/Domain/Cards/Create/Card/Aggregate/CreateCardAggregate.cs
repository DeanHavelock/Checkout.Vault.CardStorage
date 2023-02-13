using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Command;
using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Event;

namespace Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Aggregate;

/// <summary>
/// The create card aggregate
/// </summary>
public class CreateCardAggregate
{
    /// <summary>
    /// Constructor for the dependencies
    /// </summary>
    public CreateCardAggregate()
    {
        Card = Entities.Card.CreateEmpty();
    }

    /// <summary>
    /// The card entity
    /// </summary>
    public Entities.Card Card;

    /// <summary>
    /// Process a command and return an event
    /// </summary>
    /// <param name="command">The command</param>
    /// <returns>An event</returns>
    public DomainEvent Process(CreateCardCommand command)
    {
        Card = new Entities.Card()
            .SetCardNumber(command.CardNumber)
            .SetExpiryMonth(command.ExpiryMonth)
            .SetExpiryYear(command.ExpiryYear);

        return new CardCreatedEvent() { };
    }
}
