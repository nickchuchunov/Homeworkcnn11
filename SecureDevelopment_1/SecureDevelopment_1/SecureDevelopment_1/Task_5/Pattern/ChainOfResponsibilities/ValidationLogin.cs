namespace SecureDevelopment_1
{
    public class ValidationLogin : ChainOfResponsibililitiesAbstract
    {

        public override BankCardContract Responsibilities(BankCardContract obj)
        {


            if (obj.Login.GetType() == typeof(string))
            {
                base._chainOfResponsibilities.Login = obj.Login;
                return obj;
            }
            else
            {
                obj.Login = string.Empty;
                base._chainOfResponsibilities.Login = string.Empty;
                return obj;
            }

        }

    }
}
