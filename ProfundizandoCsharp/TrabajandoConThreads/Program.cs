namespace TrabajandoConThreads;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            //Thread t = new Thread(EjecutarTarea);

            //t.Start();

            ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
        }

        Console.WriteLine();
    }

    static void EjecutarTarea(Object o) 
    {
        int nTarea = (int)o;

        Console.WriteLine($"Thread nro: {Thread.CurrentThread.ManagedThreadId} ha comenzando su tarea nro {nTarea} ");


        Thread.Sleep(1000);

        Console.WriteLine($"Thread nro: {Thread.CurrentThread.ManagedThreadId} ha terminado su tarea nro {nTarea} ");
    }
}