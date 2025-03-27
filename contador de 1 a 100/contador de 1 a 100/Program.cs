using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_de_1_a_100
{
    internal class Program
    {//CONTADOR DE 0 A 100
        static void Main(string[] args)
        {
            int contador;

            // PARA = for
            for (contador = 0; contador < 101; contador = contador + 2)
            {   // Console.Write é usado como escreva se vc adicionar um line "Console.Writeline" ele fica espassado bunitinho um embaixo do outro ou sa o "\n"
                Console.WriteLine(" " + contador);
            }
        }
    }
}