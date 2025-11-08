using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using PlushiesRUs.Models;
using CsvHelper;
using System.Globalization;

namespace PlushiesRUs.DB
{
    public class PlushiesRUsDB
    {
        public string CustomersCsvPath { get; }
        public string ProductsCsvPath { get; }
        public string ProductPackagesCsvPath { get; }
        public string PurchasesCsvPath { get; }

        public PlushiesRUsDB(string customersCsv, string productsCsv, string productPackagesCsv, string purchasesCsv)
        {
            CustomersCsvPath = customersCsv;
            ProductsCsvPath = productsCsv;
            ProductPackagesCsvPath = productPackagesCsv;
            PurchasesCsvPath = purchasesCsv;
        }
    }
}