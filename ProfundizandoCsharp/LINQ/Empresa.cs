namespace LINQ
{
    public class Empresa
    {
        public int Id { get; set; }
        public String Nombre { get; set; } = string.Empty;
        public List<Empleado> EmpresaConEmpleados = new List<Empleado>();
        public void getDatosEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Nombre, Id);
        }
    }
}
