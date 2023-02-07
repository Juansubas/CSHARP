using APIPRUEBAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIPRUEBAS.Controllers
{
    //Con Route se define la ruta para acceder
    [Route("api/[controller]")]
    //Con ApiController Indicamos que la clase es un controlador
    //y tendrá una estructura de controlador
    [ApiController]
    public class ProductoController : ControllerBase
    {   
        //Con readonly mediante constructores podemos manipularlo
        public readonly DbapiContext _dbcontext;

        //Creamos el constructor para asignar la conexión a base de datos
        public ProductoController(DbapiContext _context)
        {
            _dbcontext = _context;
        }

        [HttpGet]
        [Route("Lista")]

        public IActionResult Lista()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                //Incluimos a la consulta el objeto categoria
                lista = _dbcontext.Productos.Include(c => c.oCategoria).ToList();
                //Imprimir toda la lista de Productos
                //lista = _dbcontext.Productos.ToList();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            }
            catch(Exception ex) {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

    }
}
