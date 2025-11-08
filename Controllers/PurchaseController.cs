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
[Route("purchases")]
public class PurchaseController : ControllerBase
{
    private readonly ILogger<PurchaseController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;
    private readonly PurchaseService _purchaseService;

    public PurchaseController(
        ILogger<PurchaseController> logger, 
        PlushiesRUsDbOperationsContext dbContext, 
        PurchaseService purchaseService
    )
    {
        _logger = logger;
        _dbContext = dbContext;
        _purchaseService = purchaseService;
    }

    [HttpGet()]
    public IActionResult GetAllPurchases()
    {
        var purchases = _purchaseService.GetAllPurchases();
        return Ok(purchases);
    }

}
