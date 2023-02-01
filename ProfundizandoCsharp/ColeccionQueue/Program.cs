using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //Rellenado o agregando elementos a la cola

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10})
            {
                //Agregando
                numeros.Enqueue(numero);
            }

            //Recorriendo la cola
            Console.WriteLine("Recorriendo el Queue");

            foreach(int numero in numeros) 
            {
                Console.WriteLine(numero);
            }

            //Eliminando elementos del Queue
            Console.WriteLine("Eliminando Elementos");

            //Elimina el primer en entrar
            numeros.Dequeue();

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
