using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1, cont2=0, cont3=0, valor;
            float nota;

            Console.WriteLine("Calcular Notas");

            Console.WriteLine("ingrese la cantidad de notas: ");
            valor=int.Parse(Console.ReadLine());

            for (cont1 = 0; cont1 < valor; cont1++)
            {
                Console.WriteLine("ingrese la nota: ");
                nota = float.Parse(Console.ReadLine());

                if (nota >= 3)
                {
                    cont2++;
                }
                else
                {
                    cont3++;
                }
            }

            Console.WriteLine("las notas mayores o iguales a 3 son: " + cont2 );
            Console.WriteLine("las notas menores a 3 son: " + cont3);
            Console.ReadKey();

        }
    }
}
