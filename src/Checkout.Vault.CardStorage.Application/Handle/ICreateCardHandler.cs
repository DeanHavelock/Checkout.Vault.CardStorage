using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Command;

namespace Checkout.Vault.CardStorage.Application.Handle;

public interface ICreateCardHandler
{
    Task Process(CreateCardCommand command);
}
