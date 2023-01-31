using Microsoft.AspNetCore.Mvc;
using CustomersApi.Dtos;

namespace CustomersApi.Controllers
{
    //Indicar que es un controlador de la api
    [ApiController]
    // Con autentificación usamos lo siguiente
    //En caso de necesitar 
    //[Authorize]
    //Para crear una ruta el [controller] representa el nombre hasta antes de Controller
    // o sea que la ruta será api/Customer
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public async Task<List<CustomerDto>> GetCustomers( )
        {
            //Lanzamos una Excepción No implementada
            throw new NotImplementedException();
        }

        //api/customer/{id}
        [HttpGet("{id}")]
        public async Task<CustomerDto> GetCustomer(long id)
        {
            //Lanzamos una Excepción No implementada
            throw new NotImplementedException(); 
        }
    }
}
