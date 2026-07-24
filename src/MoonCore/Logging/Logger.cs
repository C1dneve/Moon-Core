namespace MoonCore.Logging;

public class Logger
{

    public void Log(string level, string message)
    {

        if (level == "ERROR")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if(level == "WARNING")
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        }      
        
        Console.WriteLine($"[{level}] {message}");
        
        Console.ResetColor();
    }
    public void Info(string message)
    {
        Log("INFO", message);
    }

    public void Error(string message)
    {   
        Log("ERROR", message);
    }

    public void Warning(string message)
    {
        Log("WARNING", message);
    }
}

