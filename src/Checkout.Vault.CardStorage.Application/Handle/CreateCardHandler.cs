using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Aggregate;
using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Command;
using Checkout.Vault.CardStorage.Core.Ports;

namespace Checkout.Vault.CardStorage.Application.Handle;

/// <summary>
/// Handles creating a card
/// </summary>
public class CreateCardHandler : ICreateCardHandler
{
    private IRaiseEvent _raiseEvent;
    private ICardsRepository _cardsRepository;

    /// <summary>
    /// Constructor for dependencies
    /// </summary>
    /// <param name="cardsRepository"></param>
    /// <param name="raiseEvent"></param>
    public CreateCardHandler(ICardsRepository cardsRepository, IRaiseEvent raiseEvent)
    {
        _raiseEvent = raiseEvent;
        _cardsRepository = cardsRepository;
    }

    /// <summary>
    /// Handles the orchestration of processing for the create card command
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public async Task Process(CreateCardCommand command)
    {
        //Retrieve any query results used to feed into the aggregate
        // N/A...

        //Create aggregate
        var aggregate = new CreateCardAggregate();

        //Process aggregate with command
        var domainEvent = aggregate.Process(command);

        //Save State
        await _cardsRepository.Save(aggregate);

        //Raise Event
        await _raiseEvent.Publish(domainEvent);
    }
}
