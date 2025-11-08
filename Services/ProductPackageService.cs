namespace PlushiesRUs.Services;

using System.Collections.Generic;
using System.Data.SqlClient;
using PlushiesRUs.Models;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.DB;

public class ProductPackageService
{
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public ProductPackageService(PlushiesRUsDbOperationsContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<ProductPackage> GetAllProductPackages()
    {
        return _dbContext.ProductPackages;
    }

}