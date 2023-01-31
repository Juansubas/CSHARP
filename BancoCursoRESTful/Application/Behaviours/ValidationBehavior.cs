using FluentValidation;
using MediatR;

namespace Application.Behaviours
{
    /*
     *Clase Recibe dos tipos uno de Peticion y de uno de respuesta, donde a esto se le implementa la Interfaz IPipeLineBehavior
     *La cual recibe la petición y la respuesta, luego indicamos donde la petición es una implementación de IRequest la cual tiene 
     *un parámetro de salida
     *
     *IRequest y IPipieLineBehavior con interfaces de MediaTR
     *
     *Básicamente mediante los nuggets, el media nos implementa el mediador
     *y luego validamos todo lo que llega de la API esto se logra con el nugget validation
     */
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        //Creamos una variable donde almacenaremos las validaciones 
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        // Ahora bien debemos tener un manejador que canalice todas las peticiones
        /* Entonces creamos una interfaz IEnumerable, le pasamos un IValidator de nugget
         * con esto validamos todo lo que llega de la API
         *
         */
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }



        // Al implementar IPipeLineBehavior nos entrega un método Handle

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            //Si en los validators hay alguno implementado, pues debido a los generics
            //Debía cumplir con la Implementación para poder pasar
            if(_validators.Any())
            {
                var context = new FluentValidation.ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));

            }
            return await next();
        }
    }
}
