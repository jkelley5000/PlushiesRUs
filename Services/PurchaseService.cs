namespace PlushiesRUs.Services;

using System.Collections.Generic;
using System.Data.SqlClient;
using PlushiesRUs.Models;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.DB;

public class PurchaseService
{
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public PurchaseService(PlushiesRUsDbOperationsContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Purchase> GetAllPurchases()
    {
        var purchases = new List<Purchase>();
        purchases = _dbContext.Purchases.ToList();
        return purchases;
    }

    public List<Purchase> GetLoyalCustomers()
    {
        var loyalCustomers = new List<Purchase>();

        using (SqlConnection connection = new SqlConnection(_dbContext.Database.GetDbConnection().ConnectionString))
        {
            connection.Open();

            string query = "SELECT id, purchase_date, customer_id, items, amount FROM purchases WHERE customer_id IN (SELECT customer_id FROM purchases GROUP BY customer_id HAVING COUNT(customer_id) > 1)";

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var purchase = new Purchase
                        {
                            Id = reader.GetByte(0),
                            Purchase_Date = reader.GetDateTime(1),
                            Customer_Id = reader.GetInt16(2),
                            Items = reader.GetString(3),
                            Amount = reader.GetDecimal(4),
                        };

                        loyalCustomers.Add(purchase);
                    }
                }
            }
        }

        return loyalCustomers;
    }
}
