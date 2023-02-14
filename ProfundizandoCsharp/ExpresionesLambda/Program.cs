class Program
{
    public delegate int OperacionesMatematicas(int numero1, int numero2);
    static void Main(string[] args)
    {
        //Usar Delegado, con expressión lambda
        OperacionesMatematicas operacion = new OperacionesMatematicas((x,y) => x*y);

        //Llamamos el delegado
        Console.WriteLine(operacion(10,10));
        Console.WriteLine("\n-------------OTRO EJEMPLO-------------\n");
        //OTRO EJEMPLO

        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        List<int> numerosPares = numeros.FindAll(x => x%2 == 0);

        //uNA LÍNEA
        numeros.ForEach(numero => Console. WriteLine(numero));

        //Varias Lineas
        numeros.ForEach(numero =>
        {
            Console.WriteLine("El numero par es: ");
            Console.WriteLine(numero);
        });
    }

    public static int Suma(int num1, int num2)
    {
        return num1 + num2; 
    }
}