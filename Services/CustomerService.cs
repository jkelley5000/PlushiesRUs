namespace PlushiesRUs.Services;

using System.Collections.Generic;
using System.Data.SqlClient;
using PlushiesRUs.Models;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.DB;

public class CustomerService
{
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public CustomerService(PlushiesRUsDbOperationsContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Customer> GetAllCustomers()
    {
        var customers = new List<Customer>();
        customers = _dbContext.Customers.ToList();
        return customers;
    }

}