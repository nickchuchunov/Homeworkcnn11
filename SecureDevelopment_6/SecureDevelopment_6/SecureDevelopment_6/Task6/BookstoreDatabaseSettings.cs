namespace SecureDevelopment_1
{
    public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; } = "BookContract";
        public string ConnectionString { get; set; } = "mongodb://root:rootpassword@127.0.0.1:27017";
        public string DatabaseName { get; set; } = "BookServices";
    }
}
