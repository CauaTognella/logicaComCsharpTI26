using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_da_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaDamana;

            Console.Write("Digite o numero da semana: ");
            diaDamana = int.Parse(Console.ReadLine());

            if (diaDamana > 7)
            {
                Console.Write("Numero da semana invalida");
            }
            else if (diaDamana == 1 || diaDamana == 6)
            {

                Console.Write("Final de semana");
            } else { 
                Console.Write("Dia da semana normal");

               }
        }
    }
}
    

