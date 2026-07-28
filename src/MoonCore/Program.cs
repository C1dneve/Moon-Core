using MoonCore.Configuration;
using MoonCore.Core;    
using MoonCore.Services;  

ConfigurationLoader loader = new ConfigurationLoader();

AppConfiguration configuration = loader.Load();

ServiceContainer serviceContainer = new ServiceContainer(configuration);

MoonCoreApplication app = new MoonCoreApplication(serviceContainer);

app.Run();


