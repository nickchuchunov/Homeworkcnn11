using Microsoft.AspNetCore.Mvc;

namespace SecureDevelopment_1
{
    [ApiController]
    [Route("[controllerSQL]")]
    public class BankCardServiceDapperController : ControllerBase
    {
     

        private readonly ILogger<BankCardServiceController> _logger;
        private readonly BankCardServiceDapper bankCardServiceDapper;

        public BankCardServiceDapperController(ILogger<BankCardServiceController> logger, BankCardServiceDapper bankCardServiceDapper)
        {
            _logger = logger;
            this.bankCardServiceDapper = bankCardServiceDapper;
        }

        [HttpPost(Name = "CreateSQL")]
        void Create([FromQuery] int AccountNumber, [FromQuery] decimal AmounfOfFunds)
        {
            BankCardContract bankCardContract = new BankCardContract() { AccountNumber = AccountNumber, AmounfOfFunds = AmounfOfFunds };

            bankCardServiceDapper.Create(bankCardContract);

        }

        [HttpGet(Name = "ReadSQL")]
        List<BankCardContract> Read()
        {
            return bankCardServiceDapper.Read();

        }






        [HttpPost(Name = "DeleteSQL")]
        void Delete([FromQuery] int accountNumber)
        {
            bankCardServiceDapper.Delete(accountNumber);


        }


        [HttpPost(Name = "UpdateSQL")]
        void Update([FromQuery] int BankCardContractId, [FromQuery] int AccountNumber, [FromQuery] decimal AmounfOfFunds)
        {
            BankCardContract bankCardContract = new BankCardContract() { BankCardContractId = BankCardContractId, AccountNumber = AccountNumber, AmounfOfFunds = AmounfOfFunds };

            bankCardServiceDapper.Update(bankCardContract);

        }







    }
}
