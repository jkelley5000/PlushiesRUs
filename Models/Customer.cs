namespace PlushiesRUs.Models;

public class Customer
{
    public short id { get; set; }

    public string full_name { get; set; }

    public string email { get; set; }

    public DateTime? first_purchase_date { get; set; }
}
