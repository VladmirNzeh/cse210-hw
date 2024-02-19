using System;
using System.Collections.Generic;

public class Order
{
    public Customer Customer { get; set; }
    public List<Item> Items { get; set; }
    public decimal TotalPrice { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Items = new List<Item>();
        TotalPrice = 0;
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
        TotalPrice += item.Price;
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in Items)
        {
            totalPrice += item.Price;
        }
        return totalPrice;
    }

    public void PlaceOrder()
    {
        // Logic to place the order, update inventory, process payment, etc.
        // This method should be implemented according to the requirements of the system.
        Console.WriteLine($"Order placed successfully for {Customer.Name}. Total Price: {TotalPrice:C}");
    }
}
