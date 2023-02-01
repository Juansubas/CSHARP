using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);

            empleados.agregar(new Director(4500));
            empleados.agregar(new Director(1500));
            empleados.agregar(new Director(2500));
        }
    }

    class AlmacenEmpleados<T>  where T : IParaEmpleados
    {
        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void agregar( T obj)
        {
            datosEmpleado[i] = obj;

            i++;
        }

        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }

        private int i = 0;

        private T[] datosEmpleado;

    }

    class Director : IParaEmpleados
    {
        public Director (double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario() 
        {
            return salario;
        }

    }

    class Secretaria : IParaEmpleados
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario; 
        }
    }

    class Electricista : IParaEmpleados
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }

    class Estudiante
    {
        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return edad;
        }

        private double edad;
    }

    interface IParaEmpleados
    {
        double getSalario();
    }
}