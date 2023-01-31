using Practicee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicee.Errors;

namespace Practicee.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>() 
        {
            new Cerveza() { Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
            new Cerveza() { Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colima"},
            new Cerveza() { Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"}
        };

        public int GetCantidad(string Nombre)
        {
            // Vamos a buscar el objeto que tenga
            // el nombre que le indicamos
            // para después retornar la cantidad.
            // First nos regresa el primer objeto que encuentre, sino una exception. 
            // FirstOrDefault nos regresa el objeto o un null
            var cerveza = (from d in cervezas
                           where d.Nombre == Nombre
                           select d).FirstOrDefault();

            if (cerveza == null)
                throw new BeerNotFoundException("La cerveza se ha terminado");

            return cerveza.Cantidad;
        }

    }
}
