namespace LINQ
{
    public class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpleados= new List<Empleado>();
            listaEmpresas= new List<Empresa>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras Informaticas" });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Sergey Brin", Cargo = "CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan Diaz", Cargo = "CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Larry Page", Cargo = "Co-CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Irina Shayk", Cargo = "Co-CEO", EmpresaId = 1, Salario = 150000 });
        }

        public void getCEO() 
        { 
            IEnumerable<Empleado> CeoEmpleados = from Empleado in listaEmpleados where Empleado.Cargo == "CEO" select Empleado;
            foreach(Empleado empleados in CeoEmpleados)
            {
                empleados.getDatosEmpleado();
            }
        }
    }
}
