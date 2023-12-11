using backend.Data;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers();

// Configure Entity Framework Core with SQL Server
builder.Services.AddDbContext<DataContext>(options =>


{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Additional services for enabling CORS and Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS policy configuration
builder.Services.AddCors(options => options.AddPolicy("SuperHeroOrigins",
    policy => policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader())
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Swagger setup in Development environment
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS
app.UseCors("SuperHeroOrigins");

app.UseHttpsRedirection();
app.UseAuthorization();

// Map controllers
app.MapControllers();

app.Run();
