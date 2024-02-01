using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    private readonly List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "reflect on the good things in your life by listing as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine($"\n{_listingPrompts[i % _listingPrompts.Count]}");
            AnimateSpinner(2); // Pause for 2 seconds
            ListItems();
        }
    }

    private void ListItems()
    {
        const int countdownSeconds = 5;

        Console.WriteLine($"\nGet ready! You have {countdownSeconds} seconds to think about the prompt.");
        Countdown(countdownSeconds);

        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < countdownSeconds)
        {
            Console.Write("\nEnter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nNumber of items entered: {items.Count}");
    }
}
