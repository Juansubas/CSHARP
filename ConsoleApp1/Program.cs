using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var manchas = new Perro();
            Console.WriteLine(manchas.Toca());

            var michi = new Gato();
            Console.WriteLine(michi.Toca());

        }
    }
}
