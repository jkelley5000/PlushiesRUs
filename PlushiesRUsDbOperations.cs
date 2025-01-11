using System;
using System.Collections.Generic;
using PlushiesRUs.DB;
using PlushiesRUs.Models;
using Microsoft.EntityFrameworkCore;

public class PlushiesRUsDbOperationsContext : DbContext
{
    public PlushiesRUsDbOperationsContext(DbContextOptions<PlushiesRUsDbOperationsContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductPackage> Product_Packages { get; set; }
    public DbSet<Purchase> Purchases { get; set; }

}