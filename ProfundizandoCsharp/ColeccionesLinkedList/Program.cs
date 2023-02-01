using System;
using System.Collections.Generic;

namespace ColeccionesLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 })
            {
                numeros.AddFirst(numero);
            }

            //numeros.Remove(6);

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            //Este método permite trabajar con Nodos directamente, pudiendo agregarlo.
            numeros.AddFirst(nodoImportante);

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            
            /*Representa los nodos de una clase LinkedList
             * por lo tanto le pasamos el primer nodo mediante numeros.First
             * luego le indicamos con Next que salte al siguiente y obviamente
             * para detenerlo cuando no haya mas nodos sería null
             * ahora bien para obtener el valor usamos .Value pues solo estamos
             * Obteniendo los nodos
             */
            for(LinkedListNode<int> nodo = numeros.First; nodo!=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;

                Console.WriteLine(numero);
            }
        }
    }
}
