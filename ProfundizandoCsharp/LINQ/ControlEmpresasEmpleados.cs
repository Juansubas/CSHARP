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
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan Diaz", Cargo = "CEO", EmpresaId = 2, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Larry Page", Cargo = "Co-CEO", EmpresaId = 1, Salario = 150000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Irina Shayk", Cargo = "Co-CEO", EmpresaId = 2, Salario = 150000 });
        }

        public void getCEO() 
        { 
            IEnumerable<Empleado> CeoEmpleados = from Empleado in listaEmpleados where Empleado.Cargo == "CEO" select Empleado;
            foreach(Empleado empleados in CeoEmpleados)
            {
                empleados.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenado()
        {
            IEnumerable<Empleado> empleadosOrdenados = from empleado in listaEmpleados orderby empleado.Nombre descending select empleado;

            foreach( Empleado empleado in empleadosOrdenados) 
            {
                empleado.getDatosEmpleado();
            }

        }
        
        public void getEmpleadosPildoras()
        {
            //La logica detras es Empleado es aquel elemento que iterara a listaEmpleados, luego
            //agreagamos otra tabla y sera empresa que iterara a listaEmpresas
            //Luego vinculamos dicha tablas por sus correspondientes ID, por lo tanto traera todos los id que hagan match
            //luego evaluamos de ese vinculo que condiciones debe tener para poderse mostrar
            //al final imprimimos empleado que es donde se almacena los resultados de todo.
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados 
                                              join empresa in listaEmpresas
                                              on empleado.EmpresaId equals empresa.Id
                                              where empresa.Nombre== "Pildoras Informaticas"
                                              select empleado;

            foreach( Empleado empleado in empleados)
            {
                empleado.getDatosEmpleado();
            }
        }

        public void getEmpleadosEmpresas(int Id)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas
                                              on empleado.EmpresaId equals empresa.Id
                                              where empresa.Id == Id
                                              select empleado;
            if(empleados.Count() > 0)
            {
                foreach (Empleado empleado in empleados)
                {
                    empleado.getDatosEmpleado();
                }
            }else
            {
                Console.WriteLine("No existe el Id otorgado");
            }




        }
    }
}
