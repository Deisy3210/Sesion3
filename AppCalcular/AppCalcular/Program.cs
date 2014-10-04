using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalcular
{
    class Program
    {
        static void Main(string[] args)
        {

            int cont1, cont2 = 0, valor, num;

            Console.WriteLine("Calcular Numeros mayores a 1000");

            Console.WriteLine("ingrese la cantidad de numeros: ");
            valor = int.Parse(Console.ReadLine());

            for (cont1 = 0; cont1 < valor; cont1++)
            {
                Console.WriteLine("ingrese el numero: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 1000)
                {
                    cont2++;
                }
            }

            Console.WriteLine("los numeros mayores o iguales a 1000 son: " + cont2);
            Console.ReadKey();
        }
    }
}
