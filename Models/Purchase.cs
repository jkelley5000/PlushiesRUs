namespace PlushiesRUs.Models;

public class Purchase
{
    public byte Id { get; set; }

    public DateTime Purchase_Date { get; set; }

    public short Customer_Id { get; set; }

    public string Items { get; set; }

    public decimal Amount { get; set; }
}
