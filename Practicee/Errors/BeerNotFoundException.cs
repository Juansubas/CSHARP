using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee.Errors
{
    //Para crear una Exception heredamos de la clase Excepction
    public class BeerNotFoundException : Exception
    {
        //Creando los constructores
        /*Recordemos que son super() llamamos al constructor padre, por lo tanto 
         *le pasamos los parámetros que recibimos
         *El primero será un constructor vario
         *el segundo da la posibilida de indicar un mensaje
         *el tercero da la posibilidad de indicar dos mensajes, uno normal y uno interno
         */
        public BeerNotFoundException() :base() { }
        public BeerNotFoundException(string message) : base(message) { }
        public BeerNotFoundException(string message, Exception inner) : base(message, inner) { }

    }
}
