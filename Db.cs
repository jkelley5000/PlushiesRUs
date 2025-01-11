using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using PlushiesRUs.Models;

namespace PlushiesRUs.DB;
public class PlushiesRUsDB
{
    private readonly string _connectionString;
    public PlushiesRUsDB(string connectionString)
    {
        _connectionString = connectionString;
    }

    public static List<Customer> GetCustomers(string connectionString)
    {
        using (var context = new PlushiesRUsDbOperationsContext(
            new DbContextOptionsBuilder<PlushiesRUsDbOperationsContext>()
                .UseSqlServer(connectionString)
                .Options))

        {
            var customers = context.Customers.ToList();

            return customers;
        }

    }

    public static List<Product> GetProducts(string connectionString)
    {
        using (var context = new PlushiesRUsDbOperationsContext(
            new DbContextOptionsBuilder<PlushiesRUsDbOperationsContext>()
                .UseSqlServer(connectionString)
                .Options))

        {
            var products = context.Products.ToList();

            return products;
        }

    }

    public static List<ProductPackage> GetProductPackages(string connectionString)
    {
        using (var context = new PlushiesRUsDbOperationsContext(
            new DbContextOptionsBuilder<PlushiesRUsDbOperationsContext>()
                .UseSqlServer(connectionString)
                .Options))

        {
            var productPackages = context.Product_Packages.ToList();

            return productPackages;
        }

    }

    public static List<Purchase> GetPurchases(string connectionString)
    {
        using (var context = new PlushiesRUsDbOperationsContext(
            new DbContextOptionsBuilder<PlushiesRUsDbOperationsContext>()
                .UseSqlServer(connectionString)
                .Options))

        {
            var purchases = context.Purchases.ToList();

            return purchases;
        }

    }

}