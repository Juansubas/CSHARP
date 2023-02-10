namespace EjercicioHerencia.Models
{
    public class Coche:Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Encendiendo carro");
        }
    }
}
