using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");

            Babieca.galopar();
        }
    }

    class Mamiferos
    {
        public Mamiferos(String Nombre)
        {
            nombreSerVivo = Nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy Capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar() => Console.WriteLine("Soy capaz de galopar");
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano): base(nombreHumano)
        {

        }
        public void pensar() => Console.WriteLine("Soy capaz de pensar ¿?");
    }
    
    class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar() => Console.WriteLine("Soy capaz de trepar");
    }
}
