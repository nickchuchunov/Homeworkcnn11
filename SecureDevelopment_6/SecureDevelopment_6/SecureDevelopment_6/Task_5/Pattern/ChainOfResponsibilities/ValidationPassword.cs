namespace SecureDevelopment_1
{
    public class ValidationPassword : ChainOfResponsibililitiesAbstract

    {


        public override BankCardContract Responsibilities(BankCardContract obj)
        {

            base.BankCard = obj;



            if (obj.Password.GetType() == typeof(string))
            {
                base.BankCard.Password = obj.Password;
                return obj;
            }
            else
            {
                obj.Password = string.Empty;
                base.BankCard.Password = string.Empty;
                return obj;
            }

        }
    }
}
