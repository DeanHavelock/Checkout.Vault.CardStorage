using Checkout.Vault.CardStorage.Api.Dto;
using Checkout.Vault.CardStorage.Application.Handle;
using Checkout.Vault.CardStorage.Core.Domain.Cards.Create.Card.Command;
using Microsoft.AspNetCore.Mvc;

namespace Checkout.Vault.CardStorage.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardsController : ControllerBase
    {
        private ICreateCardHandler _createCardHandler;

        public CardsController(ICreateCardHandler createCardHandler) {
            _createCardHandler = createCardHandler;
        }

        [HttpPost]
        public IEnumerable<string> Post(/*CreateCardDto dto*/)
        {
            var dto = new CreateCardDto() { CardNumber="4242424242424242", ExpiryMonth="02", ExpiryYear="2030"};
            var command = new CreateCardCommand() { CardNumber = dto.CardNumber, ExpiryMonth = dto.ExpiryMonth, ExpiryYear = dto.ExpiryYear };
            
            _createCardHandler.Process(command);

            return new[] { "Card Submitted" };
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "abc, 123" };
        }
    }
}