namespace SecureDevelopment_1;
using Microsoft.Extensions.Configuration;

    public class ConfigurationFilesDatabase: ConfigurationFile
{


   void  onfigurationFilesDatabase()
    {

        DatabaseContext databaseContext = new DatabaseContext();
        configurationProvider.Set("ConnectionString", databaseContext.ConnectionString); // Задаем значение файла конфигурации

    }

 }

