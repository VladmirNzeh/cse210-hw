using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize necessary objects
        Store store = new Store();
        UserInterface ui = new UserInterface();
        FileHandler fileHandler = new FileHandler();
        Logger logger = new Logger();

        // Load data from file
        object data = fileHandler.LoadData();
        // Assuming the data contains items to add to the store
        // Loop through items and add them to the store
        // Example: store.AddItem(new Item("ItemName", 10.99m, 50));

        bool running = true;
        while (running)
        {
            // Display main menu and handle user input
            ui.DisplayMainMenu();
            string userInput = ui.HandleUserInput(Console.ReadLine());

            // Logic to handle user input and perform corresponding actions
            switch (userInput.ToLower())
            {
                case "add":
                    // Prompt user to enter item details
                    Console.WriteLine("Enter item name:");
                    string itemName = Console.ReadLine();
                    Console.WriteLine("Enter item price:");
                    decimal itemPrice = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter item quantity:");
                    int itemQuantity = int.Parse(Console.ReadLine());
                    
                    // Add the item to the store
                    store.AddItem(new Item(itemName, itemPrice, itemQuantity));
                    break;
                case "remove":
                    // Prompt user to enter item name to remove
                    Console.WriteLine("Enter item name to remove:");
                    string itemToRemove = Console.ReadLine();
                    
                    // Remove the item from the store
                    store.RemoveItem(store.SearchItem(itemToRemove));
                    break;
                case "checkout":
                    // Logic to place order
                    // Create an order with items in the cart
                    Order order = new Order();
                    foreach (Item item in store.Items)
                    {
                        if (item.IsInCart)
                        {
                            order.AddItem(item);
                            item.UpdateQuantity(-1); // Reduce quantity by 1
                        }
                    }
                    // Calculate total price and place order
                    decimal totalPrice = order.CalculateTotalPrice();
                    store.ClearCart(); // Clear the cart after checkout
                    Console.WriteLine($"Order placed successfully. Total Price: {totalPrice:C}");
                    break;
                case "exit":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        // Save data to file before exiting
        fileHandler.SaveData(data);
        // Log message indicating program termination
        logger.LogMessage("Program terminated.");
    }
}
