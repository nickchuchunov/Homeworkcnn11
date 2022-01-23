using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace SecureDevelopment_1
{
    public class BankCardService :  IBankCard 
    {

      internal DatabaseContext databaseContext;


        /// <summary>
        /// Конструктор создает экземпляр DatabaseContext для взаимодействия c EntityFramework
        /// </summary>
        public BankCardService() 
        {
            DatabaseContext _databaseContext = new DatabaseContext();
            databaseContext = _databaseContext;

        }

        /// <summary>
        /// Метод создания таблицы и добавления новых bankCardContract
        /// </summary>
        /// <param name="bankCardContract"> контаркт между сервисом и базой данных </param>
        public void Create(BankCardContract bankCardContract)
        {
            
         databaseContext.Add(bankCardContract);
         databaseContext.SaveChanges();
        }

        /// <summary>
        /// Метод удаления по номеру аккаунта
        /// </summary>
        /// <param name="accountNumber"></param>
        public void Delete(int accountNumber)
        {
            
                BankCardContract t = databaseContext.Set<BankCardContract>().FindAsync(accountNumber).Result;
                databaseContext.Set<BankCardContract>().Remove(t);
                databaseContext.SaveChanges();

        }

        /// <summary>
        /// Метод чтения 
        /// </summary>
        /// <returns> list  всей таблицы</returns>
        public List <BankCardContract> Read()
        {
           return databaseContext.Set<BankCardContract>().ToList();
        }

        /// <summary>
        /// метод обнавления баланса счета по имени аккаунта
        /// </summary>
        /// <param name="bankCardContract"></param>
        public void Update(BankCardContract? bankCardContract)
        {
            BankCardContract? t = databaseContext.Set<BankCardContract>().FindAsync(bankCardContract.BankCardContractId).Result;
            t.AmounfOfFunds = bankCardContract.AmounfOfFunds;
            t.AccountNumber = bankCardContract.AccountNumber;

            databaseContext.SaveChanges();




        }
    }
}
