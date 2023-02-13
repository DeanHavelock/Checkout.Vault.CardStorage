using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.ValueObjects;

namespace Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Entities;

/// <summary>
/// The card entity
/// </summary>
public class Card
{
    /// <summary>
    /// Factory method for an card entity
    /// </summary>
    /// <returns></returns>
    internal static Card CreateEmpty() { return new() { }; }

    /// <summary>
    /// Constructor for dependencies
    /// </summary>
    public Card()
	{
		Id = Guid.NewGuid().ToString();
		CardNumber = CardNumberValueObject.CreateEmpty();
		ExpiryMonth = string.Empty;
		ExpiryYear = string.Empty;
	}

    public string Id { get; }
	public CardNumberValueObject CardNumber { get; set; }
	public string ExpiryMonth { get; set; }
	public string ExpiryYear { get; set; }

    /// <summary>
    /// Set card number to be used by the domain aggregate
    /// </summary>
    /// <param name="cardNumber"></param>
    /// <returns></returns>
    internal Card SetCardNumber(string cardNumber)
	{
		CardNumber = new CardNumberValueObject(cardNumber);
		return this;
	}

    /// <summary>
    /// Set expiry month to be used by the domain aggregate
    /// </summary>
    /// <param name="expiryMonth"></param>
    /// <returns></returns>
    internal Card SetExpiryMonth(string expiryMonth)
    {
        ExpiryMonth = expiryMonth;
        return this;
    }

    /// <summary>
    /// Set expiry year to be used by the domain aggregate
    /// </summary>
    /// <param name="expiryYear"></param>
    /// <returns></returns>
    internal Card SetExpiryYear(string expiryYear)
    {
		ExpiryYear = expiryYear;
        return this;
    }



}
