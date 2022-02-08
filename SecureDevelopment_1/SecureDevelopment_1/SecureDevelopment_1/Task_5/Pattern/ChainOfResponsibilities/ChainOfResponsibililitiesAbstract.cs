namespace SecureDevelopment_1
{
    public abstract class ChainOfResponsibililitiesAbstract : IChainOfResponsibilities
    {
        public BankCardContract _chainOfResponsibilities;

        public BankCardContract SetNext(BankCardContract obj)
        {
            this._chainOfResponsibilities = obj;
            return this._chainOfResponsibilities;
        }



        public virtual BankCardContract Responsibilities(BankCardContract obj)
        {
            if (this._chainOfResponsibilities != null)
            {
                return this._chainOfResponsibilities;
            }
            else
            {
                return null;
            }
        }

     
    }
}
