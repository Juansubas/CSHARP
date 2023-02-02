using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            //Rellenando o agregando elementos a la cola

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                //Con push ingresamos un elemento al principio del Stack<T>
                numeros.Push(numero);
            }

            //Recorriendo el stack

            Console.WriteLine("Recorriendo el Stack");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //Eliminando elemento del Stack
            Console.WriteLine("Eliminando Elementos");

            numeros.Pop(); // Elimina el primer elemento 

            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
