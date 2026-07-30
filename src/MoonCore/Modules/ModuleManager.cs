public class ModuleManager
{
     public List<IModule> Modules { get; set; } = new();

    public void AddModule(IModule module)
    {
        Modules.Add(module);
    }

    public void InitializeModules()
    {
        foreach (IModule module in Modules)
        {
            module.Initialize();
        }
    }
    
    
}