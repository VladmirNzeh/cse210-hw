using System;

public class Logger
{
    public void LogMessage(string message)
    {
        // Log the message to the console
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
