using Dapper;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;


namespace SecureDevelopment_1
{
    public class BankCardServiceDapper : IBankCard
    {

        string connectionString = "Server=.\\SQLEXPRESS; Initial Catalog=userstore;Integrated Security=True";
        /// <summary>
        /// Методсоздания таблицы по запросу SQL
        /// </summary>
        /// <param name="bankCardContract"> праметры из класса bankCardContract </param>

        public void Create(BankCardContract bankCardContract)
        {

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "INSERT INTO BankCardContract (AccountNumber, AmounfOfFunds) VALUES(@AccountNumber, @AmounfOfFunds); SELECT CAST(SCOPE_IDENTITY() as int)";
                db.Execute(sqlQuery, bankCardContract);
                int? BankCardContractId = db.Query<int>(sqlQuery, bankCardContract).FirstOrDefault();
                bankCardContract.BankCardContractId = BankCardContractId.Value;
               

            }


        }

        /// <summary>
        /// метод удаления SQL запрос
        /// </summary>
        /// <param name="accountNumber"> по имени аккаунта</param>


        public void Delete(int accountNumber)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "DELETE FROM BankCardContract WHERE AccountNumber = @accountNumber";
                db.Execute(sqlQuery, new { accountNumber });
            }
        }


        /// <summary>
        /// Метод чтения для упрощения читает только первую строчку
        /// </summary>
        /// <returns> возвращает лист </returns>
        public List<BankCardContract> Read()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                int id = 1;
                BankCardContract card = db.Query<BankCardContract>("SELECT * FROM BankCardContract ", new { id }).FirstOrDefault();
                List<BankCardContract> listCard = new List<BankCardContract>();
                listCard.Add(card);
                return listCard;


            }

        }

        /// <summary>
        /// метод обновления баланса на счете обновляет по имени счета
        /// </summary>
        /// <param name="bankCardContract"> с заполненными свойствами имя счета и баланс </param>
        public void Update(BankCardContract bankCardContract)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = "UPDATE BankCardContract SET AmounfOfFunds = @AmounfOfFunds,  WHERE AccountNumber = @AccountNumber";
                db.Execute(sqlQuery, bankCardContract);
            }
        }
    }
}
