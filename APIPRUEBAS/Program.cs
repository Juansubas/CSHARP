using Microsoft.EntityFrameworkCore;
using APIPRUEBAS.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//A�adimos un servicio para configurar el dbcontext, le indicamos que el argumento que recibe accedemos al m�todo
//UseSqlServer del cual le agregamos la configuraci�n que ofrece builder referenciando el appsetings.json 
// De esta forma el dbcontext queda configurado y tendremos acceso a sus m�todos para manipular la data
builder.Services.AddDbContext<DbapiContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL")));

//Agregaremos la configuraci�n para ignroar los ciclos, lo a�adimos a los servicios en controlador
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    //Vamos a configurar la opci�n de conversi�n en JSON
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
