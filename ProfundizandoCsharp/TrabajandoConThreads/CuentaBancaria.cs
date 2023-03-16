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

        public double RetirarEfectivo(double cantidad)
        {
            if ((Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Losiento queda {Saldo} $ en la cuenta. Hilo: {Thread.CurrentThread.Name}");

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
