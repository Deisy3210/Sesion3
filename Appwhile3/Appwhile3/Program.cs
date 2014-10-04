using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, num, cont = 1, suma=0;
            float promedio;
            Console.WriteLine("Programa valor ingresado");
            Console.WriteLine("Ingrese el valor");
            valor = int.Parse(Console.ReadLine());
            while (cont <= valor)
            {
                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
                cont++;
            }
            promedio = suma / valor;
            Console.WriteLine("La suma es: "+suma+"\n");
            Console.WriteLine("El promedio es: "+promedio);
            Console.ReadKey();
        }
    }
}
