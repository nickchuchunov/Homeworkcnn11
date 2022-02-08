namespace SecureDevelopment_1
{
    public class ValidationPassword : ChainOfResponsibililitiesAbstract

    {


        public override BankCardContract Responsibilities(BankCardContract obj)
        {


            if (obj.Password.GetType() == typeof(string))
            {
                base._chainOfResponsibilities.Password = obj.Password;
                return obj;
            }
            else 
            { 
                obj.Password = string.Empty;
                base._chainOfResponsibilities.Password= string.Empty;
                return obj;
            }
                    
        }

    }
}
