using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_de_notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double nota1, nota2, nota3, nota4, media
                ;
            Console.Write("Digite a nota 1: ");
            nota1 = Double.Parse(args[0]);

            Console.Write("Digite a nota 2: ");
            nota2 = Double.Parse(args[1]);

            Console.Write("Digite a nota 3: ");
            nota3 = Double.Parse(args[2]);

            Console.Write("Digite a nota 4: ");
            nota4 = Double.Parse(args[3]);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.Write("Aprovado com mÃŠdia: ", media);
            }
            else
            {
                Console.Write("reprovado com mÃŠdia: ", media);
            }
        }
    }
}
