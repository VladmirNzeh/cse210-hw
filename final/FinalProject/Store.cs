using System;
using System.Collections.Generic;

public class Store
{
    private List<Item> inventory;

    public Store()
    {
        this.inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }

    public Item SearchItem(string name)
    {
        return inventory.Find(item => item.Name == name);
    }

    public void DisplayAvailableItems()
    {
        Console.WriteLine("Available Items:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price:C}, Quantity: {item.Quantity}");
        }
    }
}
