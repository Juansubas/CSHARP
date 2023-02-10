using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia.Models
{
    public class Avion : Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo Avion");
        }
    }
}
