using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using PlushiesRUs.Services;

var builder = WebApplication.CreateBuilder(args);

var customerTable = builder.Configuration.GetValue<string>("Tables:CustomerTable");
var productTable = builder.Configuration.GetValue<string>("Tables:ProductTable");
var productPackageTable = builder.Configuration.GetValue<string>("Tables:ProductPackageTable");
var purchaseTable = builder.Configuration.GetValue<string>("Tables:PurchaseTable");

builder.Services.AddSingleton(new PlushiesRUs.DB.PlushiesRUsDB(
    customerTable,
    productTable,
    productPackageTable,
    purchaseTable
));

builder.Services.AddScoped<PlushiesRUs.DB.PlushiesRUsDbOperationsContext>();

builder.Services.AddControllers();
builder.Services.AddScoped<PurchaseService>();
builder.Services.AddScoped<ProductPackageService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CustomerService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
