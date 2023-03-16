namespace TrabajandoConThreads;

class Program
{
    static void Main(string[] args)
    {
        //Threads.Prueba();
        CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);
        
        //Creando un array de Hilos y lo inicializamos con 15 hilos
        Thread[] hilosPersonas = new Thread[15];

        for (int i = 0; i < 15; i++)
        {
            //Thread no acepta parametros normales
            //Thread t = new Thread(CuentaFamilia.RetirarEfectivo(500));

            //Para solucionar esto haremos un metodo que llame al RetirarEfectivo
            Thread t = new Thread(CuentaFamilia.VamosRetirarEfectivo);

            //Vamos a diferenciar los threads
            t.Name= i.ToString();

            //Almacenaremos 15 hilos
            hilosPersonas[i] = t;
        }

        // Iniciamos los hilos y fuera de eso los Sincronizamos 
        for (int i = 0; i < 15; i++)
        {
            hilosPersonas[i].Start();
            hilosPersonas[i].Join();
        }
    }
}