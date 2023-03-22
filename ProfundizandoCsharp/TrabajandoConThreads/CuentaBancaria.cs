namespace TrabajandoConThreads
{
    public class CuentaBancaria
    {
        double Saldo { get; set; }
        private Object bloqueaSaldoPositivo = new Object();

        public CuentaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public static void efectuar()
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
                t.Name = i.ToString();

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

        public double RetirarEfectivo(double cantidad)
        {
            if ((Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Lo siento queda {Saldo} $ en la cuenta. Hilo: {Thread.CurrentThread.Name}");

                return Saldo;
            }

            lock(bloqueaSaldoPositivo) 
            {
                if (Saldo >= cantidad)
                {
                    Console.WriteLine("Retirado {0} y queda {1} en la cuenta {2}", cantidad, (Saldo - cantidad), Thread.CurrentThread.Name);
                    Saldo -= cantidad;
                }
            }



            return Saldo;
        }

        public void VamosRetirarEfectivo()
        {
            Console.WriteLine("\nEsta sacando dinero el hilo: {0} ", Thread.CurrentThread.Name);
            for (int i = 0; i < 4; i++) RetirarEfectivo(500);
        }
    }
}
