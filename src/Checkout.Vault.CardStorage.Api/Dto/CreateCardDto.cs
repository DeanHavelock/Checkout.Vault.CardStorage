namespace Checkout.Vault.CardStorage.Api.Dto
{
    public class CreateCardDto
    {
        public string CardNumber { get; internal set; }
        public string ExpiryMonth { get; internal set; }
        public string ExpiryYear { get; internal set; }
    }
}
