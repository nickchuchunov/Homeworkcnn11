namespace SecureDevelopment_1
{
    public class ValidationLogin : ChainOfResponsibililitiesAbstract
    {

        public override BankCardContract Responsibilities(BankCardContract obj)
        {
            base.BankCard = obj;

            if (obj.Login.GetType() == typeof(string))
            {
                base.BankCard.Login = obj.Login;
                return obj;
            }
            else
            {
                obj.Login = string.Empty;
                base.BankCard.Login = string.Empty;
                return obj;
            }

        }

    }
}
