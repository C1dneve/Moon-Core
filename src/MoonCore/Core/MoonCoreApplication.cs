using MoonCore.Configuration;
using MoonCore.Logging;

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
        Logger logger = new Logger();
        logger.Info(AppConfiguration.Application.Name);
        logger.Info(AppConfiguration.Application.Version);

        
    }
}
