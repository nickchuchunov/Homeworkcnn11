namespace SecureDevelopment_1
{
    public interface IBankCard
    {
        public void Create(BankCardContract bankCardContract);
        public List<BankCardContract> Read();
        public void Update(BankCardContract bankCardContract);
        public void Delete(int accountNumber);

    }
}
