namespace PlushiesRUs.Models;

public class Product
{
    public byte id { get; set; }

    public string product_name { get; set; }

    public string description { get; set; }

    public bool rare { get; set; }

    public string price { get; set; }
}
