using Microsoft.AspNetCore.Mvc;


namespace SecureDevelopment_1
{
    [ApiController]
    [Route("[controller]")]
    public class BankCardServiceController : ControllerBase
    {
        

        private readonly ILogger<BankCardServiceController> _logger;
        private readonly BankCardService bankCardService;

        public BankCardServiceController(ILogger<BankCardServiceController> logger, BankCardService bankCardService)
        {
            _logger = logger;
            this.bankCardService = bankCardService;
        }

        [HttpPost(Name = "Create")]
        void Create([FromQuery] int AccountNumber, [FromQuery] decimal AmounfOfFunds)
        {
            BankCardContract bankCardContract = new BankCardContract() { AccountNumber = AccountNumber, AmounfOfFunds = AmounfOfFunds };

            bankCardService.Create(bankCardContract);

        }

        [HttpGet(Name = "Read")]
        List<BankCardContract> Read()
        {
            return bankCardService.Read();

        }






        [HttpPost(Name = "Delete")]
        void Delete([FromQuery] int accountNumber)
        {
            bankCardService.Delete(accountNumber);


        }


        [HttpPost(Name = "Update")]
        void Update([FromQuery]  int BankCardContractId, [FromQuery] int AccountNumber, [FromQuery] decimal AmounfOfFunds)
        {
            BankCardContract bankCardContract = new BankCardContract() { BankCardContractId= BankCardContractId, AccountNumber = AccountNumber, AmounfOfFunds = AmounfOfFunds };

            bankCardService.Update(bankCardContract);

        }






    }
}