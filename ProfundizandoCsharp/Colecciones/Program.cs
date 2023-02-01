using System;
using System.Collections.Generic;
using System.Threading;

namespace Colecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declarando una Lista
            List<int> numeros = new List<int>();

            Console.WriteLine("¿Cuántos Elementos Quieres Introducir");

            int elem = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"\nIngrese sus {elem} elementos ");

            for(int i = 0; i < elem; i++)
            {
                numeros.Add(Int32.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nImprimiendo Elementos ...\n");
            Thread.Sleep(5000);

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }

        }
    }
}
