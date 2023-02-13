namespace Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.ValueObjects;

/// <summary>
/// The value object for a card number
/// </summary>
public class CardNumberValueObject
{
    /// <summary>
    /// Factory method for an empty card number value object
    /// </summary>
    /// <returns></returns>
    public static CardNumberValueObject CreateEmpty() { return new(){ }; }
    
    private CardNumberValueObject() { Value = string.Empty; }

    /// <summary>
    /// Constructor for dependencies
    /// </summary>
    /// <param name="cardNumber">The value to set</param>
    /// <exception cref="ArgumentException">Invalid business rule exception</exception>
    public CardNumberValueObject(string cardNumber) 
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
            throw new ArgumentException("Value Object construction error, card number must have a value");
        Value = cardNumber;
    }

    /// <summary>
    /// The card number value
    /// </summary>
    public string Value { get; private set; }
}
