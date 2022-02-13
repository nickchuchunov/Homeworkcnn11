namespace SecureDevelopment_1
{
    public abstract class ChainOfResponsibililitiesAbstract : IChainOfResponsibilities
    {
        public IChainOfResponsibilities _chainOfResponsibilities;

        public BankCardContract BankCard { get; set; }
        public BankCardContract ValidBankCard { get; set; }

        public IChainOfResponsibilities SetNext(IChainOfResponsibilities obj)
        {
            obj.Responsibilities(BankCard);
            this._chainOfResponsibilities = obj;
            return obj;
        }



        public virtual BankCardContract Responsibilities(BankCardContract obj)
        {
            if (this.BankCard != null)
            {
                return this.BankCard;
            }
            else
            {
                return null;
            }
        }


    }
}
