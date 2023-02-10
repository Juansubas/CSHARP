ManejoArchivos miarchvo = new ManejoArchivos();
miarchvo.mensaje();

class ManejoArchivos
{
    StreamReader archivo = null;
    int contador = 0;
    string linea;

    public ManejoArchivos()
    {
        //Flujo de datos con el archivo externo o conexión
        archivo = new StreamReader(@"c:\texto.txt");

        //Ahora vamos a leerlo
        while(( linea = archivo.ReadLine() ) != null)
        {
            Console.WriteLine(linea);

            contador++; 
        }
    }

    public void mensaje()
    {
        Console.WriteLine("hay {0} líneas", contador);
    }
    ~ManejoArchivos()
    {
        archivo.Close();
    }
}