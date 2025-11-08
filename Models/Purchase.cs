namespace PlushiesRUs.Models;

public class Purchase
{
    public byte id { get; set; }

    public DateTime purchase_date { get; set; }

    public short customer_id { get; set; }

    public string items { get; set; }

    public string amount { get; set; }
}
