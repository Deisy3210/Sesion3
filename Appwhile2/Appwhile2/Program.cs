using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont=1;

            Console.WriteLine("Programa valor ingresado");
            Console.WriteLine("Ingrese el numero");
            num = int.Parse(Console.ReadLine());

            while (cont <= num)
            {
                Console.WriteLine("valor: " + cont);
                cont++;
            }

            Console.ReadKey();
        }
    }
}
