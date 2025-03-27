using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1_numero_de_0_a_100_par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////mostre numeros PARES de 0 a 100 (for)


            int contador;

            for (contador = 0; contador < 101; contador = contador + 2)
            {
                Console.WriteLine(" " + contador );
            }
        }
    }
}
  
