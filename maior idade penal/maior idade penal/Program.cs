﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_idade_penal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());  

    if(idade < 18)
    {
                Console.Write("Menor de idade penal");
    }
            else
    {
                Console.WriteLine("Maior de idade penal");
    }
        }
    }
}
    



