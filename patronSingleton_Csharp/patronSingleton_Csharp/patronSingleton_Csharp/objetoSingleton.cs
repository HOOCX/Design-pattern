using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronSingleton_Csharp
{
    class objetoSingleton
    {
        //-- Creamos el objeto

        private static objetoSingleton instanciaSingle = new objetoSingleton();


        //Hacemos que el constructor sea privado para que no sea instanciado

        private objetoSingleton() { }



        //Traemos el objeto mediante un return
        public static objetoSingleton traerInstanciaSingle()
        {
            return instanciaSingle;
        }

        //Funcion para sumar numeros
        public void sumar_Numeros(int n1, int n2)
        {
            Console.WriteLine("Introduce el primer numero:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());
            n1 = n1 + n2;

            Console.WriteLine("El resultado es: " + n1);
        }

    }
}
