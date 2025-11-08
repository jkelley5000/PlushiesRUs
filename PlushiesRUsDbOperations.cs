using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using PlushiesRUs.Models;

namespace PlushiesRUs.DB
{
    public class PlushiesRUsDbOperationsContext
    {
        private readonly PlushiesRUsDB _db;

        public PlushiesRUsDbOperationsContext(PlushiesRUsDB db)
        {
            _db = db;
        }

        /// <summary>
        /// Gets all customers from the CSV file.
        /// </summary>
        /// <returns>List of customers.</returns>
        public List<Customer> Customers
        {
            get
            {
                using var reader = new StreamReader(_db.CustomersCsvPath);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                return csv.GetRecords<Customer>().ToList();
            }
        }

        /// <summary>
        /// Gets all products from the CSV file.
        /// </summary>
        /// <returns>List of products.</returns>
        public List<Product> Products
        {
            get
            {
                using var reader = new StreamReader(_db.ProductsCsvPath);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                return csv.GetRecords<Product>().ToList();
            }
        }

        /// <summary>
        /// Gets all product packages from the CSV file.
        /// </summary>
        /// <returns>List of product packages.</returns>
        public List<ProductPackage> ProductPackages
        {
            get
            {
                using var reader = new StreamReader(_db.ProductPackagesCsvPath);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                return csv.GetRecords<ProductPackage>().ToList();
            }
        }

        /// <summary>
        /// Gets all purchases from the CSV file.
        /// </summary>
        /// <returns>List of purchases.</returns>
        public List<Purchase> Purchases
        {
            get
            {
                using var reader = new StreamReader(_db.PurchasesCsvPath);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                return csv.GetRecords<Purchase>().ToList();
            }
        }
    }
}
