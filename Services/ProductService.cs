namespace PlushiesRUs.Services;

using System.Collections.Generic;
using System.Data.SqlClient;
using PlushiesRUs.Models;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.DB;

public class ProductService
{
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public ProductService(PlushiesRUsDbOperationsContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Product> GetAllProducts()
    {
        return _dbContext.Products;
    }

}