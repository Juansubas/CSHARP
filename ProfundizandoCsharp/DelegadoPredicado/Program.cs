class Program
{
    static void Main(String[] args)
    {
        List<int> listanumeros = new List<int>();

        //con addrange añadimos los elementos que especifiquemos
        listanumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        //declaramos delegado predicado, el cual esta referenciando la función dame pares
        //el cual manejará datos enteros en su input

        Predicate<int> eldelegadopred = new Predicate<int>(DamePares);

        //creamos una lista y mediante findall le pasamos al delegado los argumentos para evaluar la función
        List<int> numpares = listanumeros.FindAll(eldelegadopred);

        // recorremos los resultados de la lista
        foreach (int num in numpares)
        {
            Console.WriteLine(num);
        }

    }

    static bool DamePares(int num)
    {
        if (num % 2 == 0) return true;
        else return false;
    }
    
    static void DamePrimos(int num)
    {
        bool Bool = true;
        for(var i = num; i > 1; i--) //1
        {
            Bool = true;
            for (var x = 2; x < i; x++) 
            {
                if(i % x == 0 )
                {
                    Bool = false;
                    break;
                }

            }
            if (Bool) return true;
            else return false;
        }
    }
}