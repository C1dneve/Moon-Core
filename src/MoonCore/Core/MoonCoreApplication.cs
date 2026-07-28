using MoonCore.Configuration;
using MoonCore.Logging;
using MoonCore.Services;  


namespace MoonCore.Core;

public class MoonCoreApplication
{
    public ServiceContainer ServiceContainer { get; set; }

    public MoonCoreApplication(ServiceContainer serviceContainer)
    {
        ServiceContainer = serviceContainer;
    }

    public void Run()
    {
        ServiceContainer.Logger.Info(ServiceContainer.AppConfiguration.Application.Name);
        ServiceContainer.Logger.Info(ServiceContainer.AppConfiguration.Application.Version);
    }
}
