using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_entre_20_e_90
{
    internal class Program
    {  // Programa que analisa se um numero está localizado entre 20 e 90 ou não 
        static void Main(string[] args)
        {  // DOUBLE = para numero inteiro e quebrado INT = somente umero inteiro
           double numero;
            // console.Wri
            Console.Write("digite o numero: ");
            //if = SE
             numero = double.Parse (Console.ReadLine());
               if (numero > 20 && numero < 90) {
                 Console.Write("numero está entre 20 e 90 ");
              }  //else = senao
                   else  { Console.Write("numero não está entre 20 e 90 "); }
        }
    }
}
