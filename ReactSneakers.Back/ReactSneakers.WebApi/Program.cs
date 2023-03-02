using ReactSneakers.Repositories;
using ReactSneakers.Repositories.Interfaces;
using ReactSneakers.Services;
using ReactSneakers.Services.Interfaces;
using WebOnkoDis.Helper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSingleton(new DbOptions() { ConnectionString = connectionString });

builder.Services.AddTransient<ISneakerService, SneakerService>();
builder.Services.AddTransient<ISneakerRepository, SneakerRepository>();


var app = builder.Build();

app.UseCors(cors => cors.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
