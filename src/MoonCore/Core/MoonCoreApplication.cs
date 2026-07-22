using MoonCore.Configuration;

namespace MoonCore.Core;

public class MoonCoreApplication
{
    public AppConfiguration AppConfiguration { get; set; } = new();

    public MoonCoreApplication(AppConfiguration configuration)
    {
        AppConfiguration = configuration;
    }

    public void Run()
    {
        Console.WriteLine(AppConfiguration.Application.Name);
        Console.WriteLine(AppConfiguration.Application.Version);
    }
}
