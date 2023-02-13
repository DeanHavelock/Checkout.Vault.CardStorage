namespace Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Command;

/// <summary>
/// The create card command
/// </summary>
public class CreateCardCommand
{
    public string CardNumber { get; set; }
    public string ExpiryMonth { get; set; }
    public string ExpiryYear { get; set; }
}
