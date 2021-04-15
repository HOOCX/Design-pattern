using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronSingleton_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;

            //traer el objeto al main
            objetoSingleton objeto = objetoSingleton.traerInstanciaSingle();
            objeto.sumar_Numeros(numero1, numero2); //calcular numeros
            Console.ReadKey();
        }
    }
}
