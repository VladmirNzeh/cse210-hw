using System;

public class Logger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
