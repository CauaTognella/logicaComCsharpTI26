﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_par_de_0_a_100__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while (contador < 100)
            {
                contador = contador + 2;
                Console.WriteLine(contador);
            }
        }
    }
}