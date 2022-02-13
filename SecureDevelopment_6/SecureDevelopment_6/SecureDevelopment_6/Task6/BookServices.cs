using MongoDB.Bson;
using MongoDB.Driver;


namespace SecureDevelopment_1

{
    public class BookServices 
    {
        internal IMongoCollection<BookContract> databaseContext;


        public BookServices(BookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            databaseContext = database.GetCollection<BookContract>(settings.BooksCollectionName);


        }

        public List<BookContract> Get() => databaseContext.Find(book => true).ToList();

        public BookContract Get(string id) => databaseContext.Find<BookContract>(BookContract => BookContract.BookId == id).FirstOrDefault();

        public BookContract Create(BookContract book)
        {
            databaseContext.InsertOne(book);
            return book;
        }

        public void Update(string id, BookContract bookIn) => databaseContext.ReplaceOne(BookContract => BookContract.BookId == id, bookIn);

        public void Remove(BookContract bookIn) => databaseContext.DeleteOne(BookContract => BookContract.BookId == bookIn.BookId);

        public void Remove(string id) => databaseContext.DeleteOne(BookContract => BookContract.BookId == id);





    }
}
