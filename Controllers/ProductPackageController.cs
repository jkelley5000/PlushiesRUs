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
[Route("product-packages")]
public class ProductPackageController : ControllerBase
{
    private readonly ILogger<ProductPackageController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;
    private readonly ProductPackageService _productPackageService;

    public ProductPackageController(
        ILogger<ProductPackageController> logger, 
        PlushiesRUsDbOperationsContext dbContext,
        ProductPackageService productPackageService
    )
    {
        _logger = logger;
        _dbContext = dbContext;
        _productPackageService = productPackageService;
    }

    [HttpGet("all")]
    public IActionResult GetAllProductPackages()
    {
        var productPackages = _productPackageService.GetAllProductPackages();
        return Ok(productPackages);
    }
}
