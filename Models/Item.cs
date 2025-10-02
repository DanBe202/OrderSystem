namespace OrderSystem.Models;

public class Item
{
    private string name;
    private int quantity;
    private double price;
    private string description;
    
    public Item(string name, int quantity, double price, string description)
    {
        this.name = name;
        this.quantity = quantity;
        this.price = price;
        this.description = description;
    }
    
    public string Name { get => name; set => name = value; }
    public int Quantity { get => quantity; set => quantity = value; }
    public double Price { get => price; set => price = value; }
    public string Description { get => description; set => description = value; }
    
    public string Stringify()
    {
        return $"Name: {name}, Quantity: {quantity}, Price: {price}, Description: {description}";
    }
}