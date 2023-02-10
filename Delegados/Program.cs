class Program
{
    // Definición del objeto delegado
    delegate void ObjetoDelegado(string msj);
    static void Main(string[] args)
    {
        // Creación del objeto Delegado apuntando al método que queremos pasar como función.
        ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

        //Utilización del delegado para llamar al método saludoBienvenida
        ElDelegado("Hola acabo de llegar");

        ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

        ElDelegado("Hola ya me voy");
    }
    
    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("Mensaje de bienvenida {0}", msj);
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Mensaje de despedida: {0}", msj);
        }
    }
}