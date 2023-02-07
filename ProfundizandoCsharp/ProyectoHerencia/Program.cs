using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo miBabieca = new Caballo("Babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;

            almacenAnimales[1] = miJuan;

            almacenAnimales[2] = miCopito;

            almacenAnimales[1].getNombre();
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

        public void getNombre() => Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);

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
