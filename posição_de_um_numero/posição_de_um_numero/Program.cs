using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posição_de_um_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double num;

            Console.Write("Digite um número entre 1 á 20: ");
            num = Double.Parse(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                Console.Write("O número ", num, " está entre 1 á 10.");
            }
            else if (num >= 11 && num <= 20)
            {
                Console.Write("O número ", num, " está entre 11 á 20.");
            }
            else if (num > 20)
            {
                Console.Write("O número ", num, " está acima de 20.");
            }
            else
            {
                Console.WriteLine("ERRO! Não foi digitado um número válido.");
            }
        }
    }
}
