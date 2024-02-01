using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{ 
    public BreathingActivity() : base("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("\nBreathe in...");
            Thread.Sleep(1000);
            AnimateSpinner(2); // Pause for 2 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            AnimateSpinner(2); // Pause for 2 seconds
        }
    }
}
