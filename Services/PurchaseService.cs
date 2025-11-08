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
        return _dbContext.Purchases;
    }
}
