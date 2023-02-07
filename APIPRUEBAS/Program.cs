using Microsoft.EntityFrameworkCore;
using APIPRUEBAS.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Añadimos un servicio para configurar el dbcontext, le indicamos que el argumento que recibe accedemos al método
//UseSqlServer del cual le agregamos la configuración que ofrece builder referenciando el appsetings.json 
// De esta forma el dbcontext queda configurado y tendremos acceso a sus métodos para manipular la data
builder.Services.AddDbContext<DbapiContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL")));

//Agregaremos la configuración para ignroar los ciclos, lo añadimos a los servicios en controlador
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    //Vamos a configurar la opción de conversión en JSON
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
