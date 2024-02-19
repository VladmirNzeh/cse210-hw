using System;

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public bool IsInCart { get; set; }

    public Item(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        IsInCart = false;
    }

    public void UpdateQuantity(int amount)
    {
        Quantity += amount;
    }

    public bool IsAvailable()
    {
        return Quantity > 0;
    }
}
