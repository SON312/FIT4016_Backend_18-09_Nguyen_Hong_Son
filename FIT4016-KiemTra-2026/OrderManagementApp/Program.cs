using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagementApp.Data;

// Build configuration to read appsettings.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

// Configure DbContext with SQL Server
var options = new DbContextOptionsBuilder<OrderDbContext>()
    .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
    .Options;

// Test DbContext connection
using var context = new OrderDbContext(options);

Console.WriteLine("Database connection configured successfully.");
