using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(); //Con esto ya se agreg� el servicio para utilizar patch
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Aqu� se indica qu� motor de bases de datos usar y se le dice cu�l string de conexi�n debe usar
builder.Services.AddDbContext<ApplicationDbContext>(option => 
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnetcion"));
});


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

app.Run();
