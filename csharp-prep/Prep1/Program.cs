using System;

class Program
{
    static void Main(string[] args)
    {
        console.WriteLine("What is your first name? ");
        string firstName = console.ReadLine();

        console.WriteLine("What is your last name? ");
        string lastName = console.ReadLine();

        console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}