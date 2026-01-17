using Microsoft.EntityFrameworkCore;
using OrderManagementApp.Entities;

namespace OrderManagementApp.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // =========================
            // PRODUCT CONFIGURATION
            // =========================
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(p => p.Name).IsUnique();
                entity.HasIndex(p => p.Sku).IsUnique();
            });

            // =========================
            // ORDER CONFIGURATION
            // =========================
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(o => o.OrderNumber).IsUnique();
                entity.HasIndex(o => o.CustomerEmail).IsUnique();

                entity.HasOne(o => o.Product)
                      .WithMany()
                      .HasForeignKey(o => o.ProductId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // =========================
            // SEED PRODUCTS (15 records)
            // =========================
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop Dell", Sku = "SKU-001", Price = 1500, StockQuantity = 20 },
                new Product { Id = 2, Name = "Laptop HP", Sku = "SKU-002", Price = 1400, StockQuantity = 25 },
                new Product { Id = 3, Name = "Laptop Asus", Sku = "SKU-003", Price = 1300, StockQuantity = 30 },
                new Product { Id = 4, Name = "Laptop Lenovo", Sku = "SKU-004", Price = 1200, StockQuantity = 18 },
                new Product { Id = 5, Name = "MacBook Air", Sku = "SKU-005", Price = 1800, StockQuantity = 15 },
                new Product { Id = 6, Name = "MacBook Pro", Sku = "SKU-006", Price = 2200, StockQuantity = 10 },
                new Product { Id = 7, Name = "Keyboard", Sku = "SKU-007", Price = 50, StockQuantity = 100 },
                new Product { Id = 8, Name = "Mouse", Sku = "SKU-008", Price = 30, StockQuantity = 120 },
                new Product { Id = 9, Name = "Monitor 24 inch", Sku = "SKU-009", Price = 300, StockQuantity = 40 },
                new Product { Id = 10, Name = "Monitor 27 inch", Sku = "SKU-010", Price = 450, StockQuantity = 35 },
                new Product { Id = 11, Name = "Printer", Sku = "SKU-011", Price = 250, StockQuantity = 20 },
                new Product { Id = 12, Name = "Scanner", Sku = "SKU-012", Price = 200, StockQuantity = 15 },
                new Product { Id = 13, Name = "Webcam", Sku = "SKU-013", Price = 80, StockQuantity = 60 },
                new Product { Id = 14, Name = "Headphone", Sku = "SKU-014", Price = 120, StockQuantity = 50 },
                new Product { Id = 15, Name = "Speaker", Sku = "SKU-015", Price = 150, StockQuantity = 45 }
            );

            // =========================
            // SEED ORDERS (30 records)
            // =========================
            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, OrderNumber = "ORD-20260101-0001", CustomerName = "John Doe", CustomerEmail = "john1@email.com", ProductId = 1, Quantity = 1, OrderDate = new DateTime(2026, 1, 1) },
                new Order { Id = 2, OrderNumber = "ORD-20260101-0002", CustomerName = "Alice Smith", CustomerEmail = "alice2@email.com", ProductId = 2, Quantity = 2, OrderDate = new DateTime(2026, 1, 1) },
                new Order { Id = 3, OrderNumber = "ORD-20260102-0003", CustomerName = "Bob Brown", CustomerEmail = "bob3@email.com", ProductId = 3, Quantity = 1, OrderDate = new DateTime(2026, 1, 2) },
                new Order { Id = 4, OrderNumber = "ORD-20260102-0004", CustomerName = "Emma Wilson", CustomerEmail = "emma4@email.com", ProductId = 4, Quantity = 1, OrderDate = new DateTime(2026, 1, 2) },
                new Order { Id = 5, OrderNumber = "ORD-20260103-0005", CustomerName = "Liam Taylor", CustomerEmail = "liam5@email.com", ProductId = 5, Quantity = 1, OrderDate = new DateTime(2026, 1, 3) },
                new Order { Id = 6, OrderNumber = "ORD-20260103-0006", CustomerName = "Noah Martin", CustomerEmail = "noah6@email.com", ProductId = 6, Quantity = 1, OrderDate = new DateTime(2026, 1, 3) },
                new Order { Id = 7, OrderNumber = "ORD-20260104-0007", CustomerName = "Olivia Lee", CustomerEmail = "olivia7@email.com", ProductId = 7, Quantity = 2, OrderDate = new DateTime(2026, 1, 4) },
                new Order { Id = 8, OrderNumber = "ORD-20260104-0008", CustomerName = "James White", CustomerEmail = "james8@email.com", ProductId = 8, Quantity = 3, OrderDate = new DateTime(2026, 1, 4) },
                new Order { Id = 9, OrderNumber = "ORD-20260105-0009", CustomerName = "Sophia Hall", CustomerEmail = "sophia9@email.com", ProductId = 9, Quantity = 1, OrderDate = new DateTime(2026, 1, 5) },
                new Order { Id = 10, OrderNumber = "ORD-20260105-0010", CustomerName = "William Young", CustomerEmail = "william10@email.com", ProductId = 10, Quantity = 1, OrderDate = new DateTime(2026, 1, 5) },

                new Order { Id = 11, OrderNumber = "ORD-20260106-0011", CustomerName = "Mia King", CustomerEmail = "mia11@email.com", ProductId = 11, Quantity = 1, OrderDate = new DateTime(2026, 1, 6) },
                new Order { Id = 12, OrderNumber = "ORD-20260106-0012", CustomerName = "Lucas Scott", CustomerEmail = "lucas12@email.com", ProductId = 12, Quantity = 1, OrderDate = new DateTime(2026, 1, 6) },
                new Order { Id = 13, OrderNumber = "ORD-20260107-0013", CustomerName = "Ava Green", CustomerEmail = "ava13@email.com", ProductId = 13, Quantity = 2, OrderDate = new DateTime(2026, 1, 7) },
                new Order { Id = 14, OrderNumber = "ORD-20260107-0014", CustomerName = "Ethan Adams", CustomerEmail = "ethan14@email.com", ProductId = 14, Quantity = 1, OrderDate = new DateTime(2026, 1, 7) },
                new Order { Id = 15, OrderNumber = "ORD-20260108-0015", CustomerName = "Isabella Baker", CustomerEmail = "isabella15@email.com", ProductId = 15, Quantity = 1, OrderDate = new DateTime(2026, 1, 8) },

                new Order { Id = 16, OrderNumber = "ORD-20260108-0016", CustomerName = "Daniel Carter", CustomerEmail = "daniel16@email.com", ProductId = 1, Quantity = 2, OrderDate = new DateTime(2026, 1, 8) },
                new Order { Id = 17, OrderNumber = "ORD-20260109-0017", CustomerName = "Grace Turner", CustomerEmail = "grace17@email.com", ProductId = 2, Quantity = 1, OrderDate = new DateTime(2026, 1, 9) },
                new Order { Id = 18, OrderNumber = "ORD-20260109-0018", CustomerName = "Henry Phillips", CustomerEmail = "henry18@email.com", ProductId = 3, Quantity = 3, OrderDate = new DateTime(2026, 1, 9) },
                new Order { Id = 19, OrderNumber = "ORD-20260110-0019", CustomerName = "Chloe Campbell", CustomerEmail = "chloe19@email.com", ProductId = 4, Quantity = 1, OrderDate = new DateTime(2026, 1, 10) },
                new Order { Id = 20, OrderNumber = "ORD-20260110-0020", CustomerName = "Jack Mitchell", CustomerEmail = "jack20@email.com", ProductId = 5, Quantity = 2, OrderDate = new DateTime(2026, 1, 10) },

                new Order { Id = 21, OrderNumber = "ORD-20260111-0021", CustomerName = "Lily Perez", CustomerEmail = "lily21@email.com", ProductId = 6, Quantity = 1, OrderDate = new DateTime(2026, 1, 11) },
                new Order { Id = 22, OrderNumber = "ORD-20260111-0022", CustomerName = "Samuel Roberts", CustomerEmail = "samuel22@email.com", ProductId = 7, Quantity = 2, OrderDate = new DateTime(2026, 1, 11) },
                new Order { Id = 23, OrderNumber = "ORD-20260112-0023", CustomerName = "Natalie Evans", CustomerEmail = "natalie23@email.com", ProductId = 8, Quantity = 1, OrderDate = new DateTime(2026, 1, 12) },
                new Order { Id = 24, OrderNumber = "ORD-20260112-0024", CustomerName = "Owen Collins", CustomerEmail = "owen24@email.com", ProductId = 9, Quantity = 2, OrderDate = new DateTime(2026, 1, 12) },
                new Order { Id = 25, OrderNumber = "ORD-20260113-0025", CustomerName = "Zoe Stewart", CustomerEmail = "zoe25@email.com", ProductId = 10, Quantity = 1, OrderDate = new DateTime(2026, 1, 13) },

                new Order { Id = 26, OrderNumber = "ORD-20260113-0026", CustomerName = "Leo Morris", CustomerEmail = "leo26@email.com", ProductId = 11, Quantity = 1, OrderDate = new DateTime(2026, 1, 13) },
                new Order { Id = 27, OrderNumber = "ORD-20260114-0027", CustomerName = "Hannah Rogers", CustomerEmail = "hannah27@email.com", ProductId = 12, Quantity = 2, OrderDate = new DateTime(2026, 1, 14) },
                new Order { Id = 28, OrderNumber = "ORD-20260114-0028", CustomerName = "Benjamin Reed", CustomerEmail = "benjamin28@email.com", ProductId = 13, Quantity = 1, OrderDate = new DateTime(2026, 1, 14) },
                new Order { Id = 29, OrderNumber = "ORD-20260115-0029", CustomerName = "Ella Cook", CustomerEmail = "ella29@email.com", ProductId = 14, Quantity = 3, OrderDate = new DateTime(2026, 1, 15) },
                new Order { Id = 30, OrderNumber = "ORD-20260115-0030", CustomerName = "Matthew Bell", CustomerEmail = "matthew30@email.com", ProductId = 15, Quantity = 1, OrderDate = new DateTime(2026, 1, 15) }
            );
        }
    }
}
