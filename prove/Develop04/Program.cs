using System;

class Program
{
    static void Main()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        Console.WriteLine("Mindfulness Activities:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        Console.Write("Choose an activity (1-3): ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    RunActivity(breathingActivity);
                    break;
                case 2:
                    RunActivity(reflectionActivity);
                    break;
                case 3:
                    RunActivity(listingActivity);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose between 1 and 3.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        MindfulnessActivity.PrintActivityLogs();
    }

    static void RunActivity(MindfulnessActivity activity)
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            activity.StartActivity(duration);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for duration.");
        }
    }
}
