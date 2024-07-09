using Microsoft.EntityFrameworkCore;
using ShoLaKi.Chat.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration; // xem cac gia tri cuar configuration

builder.Services.AddDbContext<ChatDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetValue<string>("ConnectionStrings:Dbconnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ChatDbContext>();
    db.Database.Migrate();
}

app.Run();
