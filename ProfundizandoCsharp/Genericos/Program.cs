using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Especificamos que archivos será un objeto
             *de la clase AlmacenObjetos, sin embargo 
             *debemos especificarle que objetos recibirá
             */
            AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);

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
            Empleado salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getsalario());

        }

        class AlmacenObjetos<T>
        {
            public AlmacenObjetos(int z)
            {
                //Con z indicamos el tamaño del array
                datosElemento = new T[z];
            }

            public void agregar(T obj)
            {
                datosElemento[i] = obj;

                i++; 
            }

            public T getElemento(int i)
            {
                return datosElemento[i];
            }

            //Como todo hereda de object, puede recibir cualquiera  
            private T[] datosElemento;

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