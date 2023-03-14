namespace LINQ
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        // Clave Foranea
        public int EmpresaId { get; set; }
        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado {0} con Id {1}, cargo {2} con salario {3} " +
                " pertenece a la empresa {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }
}
