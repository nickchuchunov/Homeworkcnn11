namespace SecureDevelopment_1
{
    public interface IChainOfResponsibilities
    {
        BankCardContract SetNext(BankCardContract obj);

        BankCardContract Responsibilities(BankCardContract obj); 

    }
}
