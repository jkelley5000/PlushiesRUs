using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using PlushiesRUs.Models;

namespace PlushiesRUs.DB;
public class PlushiesRUsDB
{
    private readonly string _connectionString;
    public PlushiesRUsDB(string connectionString)
    {
        _connectionString = connectionString;
    }

}