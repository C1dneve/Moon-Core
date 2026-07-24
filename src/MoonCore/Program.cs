using MoonCore.Configuration;
using MoonCore.Core;    

ConfigurationLoader loader = new ConfigurationLoader();

AppConfiguration configuration = loader.Load();

MoonCoreApplication app = new MoonCoreApplication(configuration);

app.Run();


