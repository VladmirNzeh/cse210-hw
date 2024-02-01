using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    private readonly List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine($"\n{_reflectionQuestions[i % _reflectionQuestions.Count]}");
            AnimateSpinner(2); // Pause for 2 seconds
        }
    }
}
