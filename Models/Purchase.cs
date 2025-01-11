namespace PlushiesRUs.Models;

public class Purchase
{
    public short Id { get; set; }

    public string Purchase_Date { get; set; }

    public int Customer_Id { get; set; }

    public string Items { get; set; }

    public string Amount { get; set; }
}
