using MoonCore.Configuration;

Console.WriteLine("Hello, World!");

ConfigurationLoader loader = new ConfigurationLoader();

AppConfiguration configuration = loader.Load();

Console.WriteLine(configuration.Application.Name);
Console.WriteLine(configuration.Application.Version);