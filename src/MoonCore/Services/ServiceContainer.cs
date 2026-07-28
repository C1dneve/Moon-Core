using MoonCore.Configuration;
using MoonCore.Logging;
namespace MoonCore.Services;

public class ServiceContainer
{
    public AppConfiguration AppConfiguration { get; set; } = new();

    public Logger Logger { get; set; }
       

    public ServiceContainer(AppConfiguration configuration)
    {
        AppConfiguration = configuration;
        Logger = new Logger();
    }
}

