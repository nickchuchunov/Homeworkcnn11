namespace SecureDevelopment_1
{
    public class ValidationAccountNumber : ChainOfResponsibililitiesAbstract
    {
        public override BankCardContract Responsibilities(BankCardContract obj)
        {
            base.BankCard = obj;

            if (obj.AccountNumber.GetType() == typeof(int))
            {
                base.BankCard.AccountNumber = obj.AccountNumber;
                return obj;
            }
            else
            {
                obj.AccountNumber = 0;
                base.BankCard.AccountNumber = 0;
                return obj;
            }

        }



    }
}
