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
public class PurchaseController : ControllerBase
{
    private readonly ILogger<PurchaseController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public PurchaseController(ILogger<PurchaseController> logger, PlushiesRUsDbOperationsContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetPurchases")]
    public IEnumerable<Purchase> Get()
    {
        var purchases = _dbContext.Purchases.ToList();
        return purchases;
    }
}
