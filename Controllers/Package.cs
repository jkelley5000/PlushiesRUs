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
public class PackageController : ControllerBase
{
    private readonly ILogger<PackageController> _logger;
    private readonly PlushiesRUsDbOperationsContext _dbContext;

    public PackageController(ILogger<PackageController> logger, PlushiesRUsDbOperationsContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetPackages")]
    public IEnumerable<Package> Get()
    {
        var packages = _dbContext.Packages.ToList();
        return packages;
    }
}
