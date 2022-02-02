namespace SecureDevelopment_1
{
    public class ConfigurationFile
    {

      public IConfigurationProvider configurationProvider { get; set; }
        public IConfiguration Configuration { get; set; }   

       public  ConfigurationFile(IServiceCollection services)
        {

            Configuration.GetSection("ConnectionString"); // добавление секции в файл конфигурации

        }

    }
}
