using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int Duration;
    protected static int ActivityCount;
    protected static int TotalDuration;

    public void StartActivity(int duration)
    {
        Duration = duration;
        PrintStartingMessage();
        Thread.Sleep(3000); // Simulate a pause with a spinner
        PerformActivity();
        PrintFinishingMessage();
        LogActivity();
    }

    protected abstract void PerformActivity();

    private void PrintStartingMessage()
    {
        Console.WriteLine($"Starting {GetType().Name}...");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine("Prepare to begin.");
    }

    private void PrintFinishingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {GetType().Name} for {Duration} seconds.");
        Console.WriteLine();
    }

    private void LogActivity()
    {
        ActivityCount++;
        TotalDuration += Duration;
    }

    public static void PrintActivityLogs()
    {
        Console.WriteLine("Activity Logs:");
        Console.WriteLine($"Total activities: {ActivityCount}");
        Console.WriteLine($"Total duration: {TotalDuration} seconds");
    }
}
