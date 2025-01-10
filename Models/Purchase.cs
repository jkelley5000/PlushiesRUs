namespace PlushiesRUs.Models;

public class Purchase
{
    public int Id { get; set; }

    public string PurchaseDate { get; set; }

    public int CustomerId { get; set; }

    public string Items { get; set; }

    public string Amount { get; set; }
}
