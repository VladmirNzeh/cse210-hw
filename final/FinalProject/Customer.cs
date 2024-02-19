using System;
using System.Collections.Generic;

public class Customer
{
    public string Name { get; set; }
    public string Id { get; set; }
    public List<Item> Cart { get; set; }

    public Customer(string name, string id)
    {
        Name = name;
        Id = id;
        Cart = new List<Item>();
    }

    public void AddToCart(Item item)
    {
        Cart.Add(item);
    }

    public void RemoveFromCart(Item item)
    {
        Cart.Remove(item);
    }

    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (var item in Cart)
        {
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
        }
    }
}
