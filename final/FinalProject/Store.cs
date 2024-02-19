using System;
using System.Collections.Generic;

public class Store
{
    private List<Item> items;

    public Store()
    {
        this.items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public Item SearchItem(string name)
    {
        return items.Find(item => item.Name == name);
    }

    public void DisplayAvailableItems()
    {
        Console.WriteLine("Available Items:");
        foreach (var item in items)
        {
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
        }
    }
}
