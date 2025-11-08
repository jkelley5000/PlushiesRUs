using Microsoft.AspNetCore.Mvc;
using PlushiesRUs.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.DB;
using PlushiesRUs.Services;

namespace PlushiesRUs.Controllers;

[ApiController]
[Route("customers")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;
    private readonly CustomerService _customerService;

    public CustomerController(
        ILogger<CustomerController> logger, 
        PlushiesRUsDbOperationsContext dbContext,
        CustomerService customerService
    )
    {
        _logger = logger;
        _dbContext = dbContext;
        _customerService = customerService;
    }

    [HttpGet()]
    public IActionResult GetAllCustomers()
    {
        var customers = _customerService.GetAllCustomers();
        return Ok(customers);
    }
}
