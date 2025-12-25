using CategoryAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký Controller
builder.Services.AddControllers();

// Đăng ký Service với DI (Scoped)
builder.Services.AddScoped<ICategoryService, CategoryService>();

// Thêm Swagger (PHỤC VỤ TEST API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Bật Swagger trong môi trường Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Map route cho Controller
app.MapControllers();

// Chạy ứng dụng
app.Run();