﻿namespace TrabajandoConThreads;

class Program
{
    static void Main(string[] args)
    {
        //Con esto acabamos de crear un nuevo hilo
        Thread t = new Thread(MetodoSaludo);
        //Ahora le indicamos que empiece
        t.Start();
        //Process Synchronous
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