namespace TrabajandoConThreads
{
    public class TareasCompletadas
    {
        public static void Solucion() 
        {
            //Crear variable de TaskCOmpletionSource, le indicamos que recibira
            var tareaTerminada = new TaskCompletionSource<bool>();

            var hilo1 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 1");
                    Thread.Sleep(1000);
                }

                //CON EL METODO TrySetResult
                //Indicamos el estado de la task
                tareaTerminada.TrySetResult(true);
            });

            var hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 2");
                    Thread.Sleep(1000);
                }
            });

            var hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo 3");
                    Thread.Sleep(1000);
                }
            });

            hilo1.Start();
            hilo2.Start();
            //Atraparemos el estado de la task, pero no deja continua el codigo hasta obtener dicho resultado
            //en este caso realizara hilo1 e hilo 2, pero hasta que hilo 1 no termine no podra iniciar el  hilo 3
            //asi el hilo 2 no haya acabado, basicamente donde pongamos el TrysetResult es donde se pondra a esperar.
            var resultado = tareaTerminada.Task.Result;

            //Con el resultado de l

            hilo3.Start();
        }
    }
}
