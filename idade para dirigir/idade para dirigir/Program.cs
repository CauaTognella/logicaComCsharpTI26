using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade_para_dirigir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

    Console.Write("Digite a idade para obter a carteira de motorista");
    idade = int.Parse(args[0]);

    if(idade < 17)
    {
                Console.Write("NÃ£o pode dirigir");
    }
            else
    {
                Console.Write("Pode dirigir");
    }
        }
    }
}
    

