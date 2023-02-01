using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);

            //archivos.agregar("Juan");

            //archivos.agregar("Elena");

            //archivos.agregar("Antonio");

            //archivos.agregar("Sandra");

            //String nombrePersona = (String)archivos.getElemento(2);

            //Console.WriteLine(nombrePersona);

            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));

            //Aquí podemos ver que al pasarle un objeto diferente
            //Nos vemos obligados a transformarlo a ese tipo de objeto
            //Dejando de ser automático fácilmente, además ya no es útil
            //El nombre de la variable que era nombrePersona
            //Además debemos invocar el Método para consultar
            Empleado salarioEmpleado = (Empleado) archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getsalario());

        }

        class AlmacenObjetos
        {
            public AlmacenObjetos(int z)
            {
                //Con z indicamos el tamaño del array
                datosElemento = new object[z];
            }

            public void agregar(Object obj)
            {
                datosElemento[i] = obj;

                i++; 
            }

            public Object getElemento(int i)
            {
                return datosElemento[i];
            }

            //Como todo hereda de object, puede recibir cualquiera  
            private Object[] datosElemento;

            private int i = 0;
        }

        class Empleado
        {
            public Empleado(double salario)
            {
                this.salario = salario;
            }


            private double salario;

            public double getsalario()
            {
                return salario;
            }

        }
    }
}