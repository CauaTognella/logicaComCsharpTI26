using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_iguais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2;

    Console.Write("Digite um número: ");
    num1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
    num2 = Double.Parse(Console.ReadLine());

            if (num1 == num2) {
                Console.WriteLine("Números iguais");
            }
            else {
                Console.WriteLine("Esse números não são iguais");

        }
        }
    }
}
