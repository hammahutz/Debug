using System;

namespace Debug.Two;

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}
