using Microsoft.Extensions.Configuration;

namespace MoonCore.Configuration;

public class ConfigurationLoader
{
    public AppConfiguration Load()
    {
        string configPath = "config/appsettings.json";

        ConfigurationBuilder builder = new ConfigurationBuilder();

        builder.SetBasePath(Directory.GetCurrentDirectory());

        builder.AddJsonFile(
            configPath,
            optional: false,
            reloadOnChange: true
        );

        IConfigurationRoot configuration = builder.Build();

        AppConfiguration config = new();

        configuration.Bind(config);

        return config;
    }
}