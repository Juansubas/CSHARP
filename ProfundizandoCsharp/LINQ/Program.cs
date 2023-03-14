using System;
using System.Linq;

namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        var ceo = new ControlEmpresasEmpleados();
        ceo.getCEO();
    }
    static void LinqOne()
    {
        int[] valoresNumericos = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Numeros Pares");

        //SIN LINQ

        //List<int> numerosPares = new List<int>();

        //foreach (var item in valoresNumericos)
        //{
        //    if( item % 2 == 0)
        //        numerosPares.Add(item);
        //}

        //CON LINQ

        //Le indicamos que almacenara enteros
        IEnumerable<int> numerosPares = from numero in valoresNumericos where numero % 2 == 0 select numero;

        foreach (var item in numerosPares)
        {
            Console.WriteLine(item);
        }
    }
}