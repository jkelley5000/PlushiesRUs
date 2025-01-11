namespace PlushiesRUs.Models;

public class Product
{
    public byte Id { get; set; }

    public string Product_Name { get; set; }

    public string Description { get; set; }

    public bool Rare { get; set; }

    public decimal Price { get; set; }
}
