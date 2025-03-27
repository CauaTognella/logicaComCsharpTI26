using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qual_dos_3_numeros_e_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("escreva um numero ");
             num1 = int.Parse(Console.ReadLine());
              Console.Write("escreva um numero ");
                num2 = int.Parse(Console.ReadLine());
                 Console.Write("escreva um numero ");
                   num3 = int.Parse(Console.ReadLine());
            if (num1 < num2 && num1 < num3) {
                Console.Write("o menor numero é o numero: " + num1);
            }
            if (num2 < num1 && num2 < num3) {
                Console.Write("o menor numero é o numero: ", num2);
            }
            if (num3 < num2 && num3 < num1) {
                Console.Write("o menor numero é o numero: ", num3);
            }
        }
    }
}
