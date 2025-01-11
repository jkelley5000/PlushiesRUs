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
public class ProductPackageController : ControllerBase
{
    private readonly ILogger<ProductPackageController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public ProductPackageController(ILogger<ProductPackageController> logger, PlushiesRUsDbOperationsContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetProductPackages")]
    public IEnumerable<ProductPackage> Get()
    {
        var productPackages = _dbContext.Product_Packages.ToList();
        return productPackages;
    }
}
