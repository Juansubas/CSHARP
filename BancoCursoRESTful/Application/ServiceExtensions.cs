using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtensions
    {
        //Vamos a Definir la plantilla de application
        //Vamos a recibir IServiceCollection y con this extendemos el método
        // Indicando que todo el que Acceda a services podra usar AddApplicationLayer
        //Mediante esto vamos a poder matricular servicios o adicionarlos.
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            // Para Agregar los Mapeos automaticamente.
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //Esto permite validar, aunque esto debería ir en Program.CS de la Presentation API
            // Pero como estamos jugando a no estar fuertemente acoplados
            //El hecho de tener la inyección de depedencias de cada nugget
            //Permite que podamos usarlo por fuera del Program.cs y no depender de el.
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            //Ejecutar el patron Mediator, esto permite hacer la referencia del proyecto.
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
