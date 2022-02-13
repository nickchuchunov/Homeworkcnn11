namespace SecureDevelopment_1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class ConfigurationFilesDatabase: ConfigurationFile
{
    public ConfigurationFilesDatabase(IServiceCollection services) : base(services)
    {
    }

    void  onfigurationFilesDatabase()
    {

        DatabaseContext databaseContext = new DatabaseContext();
        configurationProvider.Set("ConnectionString", databaseContext.ConnectionString); // Задаем значение файла конфигурации

    }

 }

