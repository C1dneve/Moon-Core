using MoonCore.Logging;
public class TestModule : IModule
{
    private Logger _logger;

    public TestModule(Logger logger)
    {
        _logger = logger;
    }

    public void Initialize()
    {
        _logger.Info("Test module initialized.");
    }
}