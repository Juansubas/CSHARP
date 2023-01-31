// See https://aka.ms/new-console-template for more information
string messageHelloWorld = "Hello, World";

Console.WriteLine("Ingresa tu nombre: ");
string lectura = Console.ReadLine();
Console.WriteLine(getHelloWorld(lectura));


string getHelloWorld(string message)
{
    return "Me llamo " + message + " y les doy el hola mundo desde consola";
}
