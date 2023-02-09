using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia.Models
{
    public class Vehiculo
    {
        public void ArrancarMotor()
        {
            Console.WriteLine("Arrancando Motor");
        }

        public void DetenerMotor() 
        {
            Console.WriteLine("Deteniendo Motor");
        }

        public virtual void Conducir() 
        {
            Console.WriteLine("Conduciendo tal cosa");
        }
    }
}
