using Backend.DatabaseContexts;
using Backend.Services.OrderService;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("API");
builder.Services.AddDbContext<DatabaseContext>(
    options => options.UseSqlServer(connectionString)
    );
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        );
});
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IOrderService, OrderServicecs>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
