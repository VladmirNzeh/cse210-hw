public class UserInterface
{
    public void DisplayMainMenu()
    {
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. Add Item to Cart");
        Console.WriteLine("2. Remove Item from Cart");
        Console.WriteLine("3. Checkout");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    public string HandleUserInput(string userInput)
    {
        // Logic to handle user input and return the corresponding action
        return userInput;
    }
}
