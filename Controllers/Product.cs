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
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public ProductController(ILogger<ProductController> logger, PlushiesRUsDbOperationsContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetProducts")]
    public IEnumerable<Product> Get()
    {
        var products = _dbContext.Products.ToList();
        return customers;
    }
}
