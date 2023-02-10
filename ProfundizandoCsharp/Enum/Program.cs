class Program
{
    static void Main(string[] args)
    {
        Empleado Juan = new Empleado(Bonus.extra, 1900.50);

        Console.WriteLine($"El salario del empleado es: {Juan.salario}");
    }
}

class Empleado
{


    public Empleado(Bonus bonusEmpleado, double salario)
    {
        bonus = (double)bonusEmpleado;

        this.salario = salario;
    }

    public double salario { get; set; }
    public double bonus { get; set; }

}

enum Bonus { bajo = 500, normal = 1000, bueno=1500, extra=3000};