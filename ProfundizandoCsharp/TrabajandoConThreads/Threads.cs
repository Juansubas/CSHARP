using System;
using System.Threading;

namespace TrabajandoConThreads
{
    public class Threads
    {
        public static void Prueba()
        {
            //Con esto acabamos de crear un nuevo hilo
            Thread t = new Thread(MetodoSaludo);
            //Ahora le indicamos que empiece
            t.Start();
            //thread synchronize 
            t.Join();
            //Process Synchronous

            Thread t2 = new Thread(MetodoSaludo);
            t2.Start();
            t2.Join();

            Console.WriteLine("Hola alumnos desde thread (o  hilo) 1");
            //Suspends the current thread for the spicified number of milliseconds
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 1");
        }
        static void MetodoSaludo()
        {
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hola alumnos desde thread (o  hilo) 2");
        }
    }
}
