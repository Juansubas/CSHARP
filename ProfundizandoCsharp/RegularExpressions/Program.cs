
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string frase = "Mi nombre es Juan y mi n de tfno es (+34)123-45-67 y mi código postal es 29679";

        //"[J]" Buscamos una letra en particular
        //Con \d buscamos un numero si escribimos n barras d hará match a varios numeros consecutivos
        //\d\d\d pero esto se puede simplicar usando \d{3}
        // Para buscar el formato 123-45-67 lo hariamos con la siguiente expresión \d{3}-\d{2}-\d{2}
        //Encontrar dos Numeros por ejemplo unimos con | por ejemplo \+34|\+44
        // Mi web es https://www.pildoras.com https://pildoras.com <- para buscar esto se debe usar https://(www.)?

        string patron = @"\d";

        Regex miRegex = new Regex(patron);

        MatchCollection elMatch = miRegex.Matches(frase);

        if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado numero de tfno");
        else Console.WriteLine("No se ha encontrado numeros de tfno");
    }
}