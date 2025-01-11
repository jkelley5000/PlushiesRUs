using Microsoft.AspNetCore.Mvc;
using PlushiesRUs.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.DB;

namespace PlushiesRUs.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public CustomerController(ILogger<CustomerController> logger, PlushiesRUsDbOperationsContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetCustomers")]
    public IEnumerable<Customer> Get()
    {
        var customers = _dbContext.Customers.ToList();
        return customers;
    }
}
