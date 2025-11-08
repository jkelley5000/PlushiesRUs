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
[Route("products")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;
    private readonly ProductService _productService;

    public ProductController(
        ILogger<ProductController> logger, 
        PlushiesRUsDbOperationsContext dbContext,
        ProductService productService
    )
    {
        _logger = logger;
        _dbContext = dbContext;
        _productService = productService;
    }

    [HttpGet()]
    public IActionResult GetAllProducts()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }
}
