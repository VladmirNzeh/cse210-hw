using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the store
        Store store = new Store();
        FileHandler fileHandler = new FileHandler();
        Logger logger = new Logger();

        // Load data from file
        store.LoadItems(fileHandler.LoadData());

        // Display the main menu
        UserInterface.DisplayMainMenu();

        // Handle user input
        string userInput = Console.ReadLine();
        UserInterface.HandleUserInput(userInput, store, logger, fileHandler);
    }
}
