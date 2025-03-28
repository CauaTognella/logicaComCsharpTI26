using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_entre_3_numeros_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double numero1, numero2, numero3;

            Console.Write("Digite o primeiro numero: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            numero3 = double.Parse(Console.ReadLine());


            if (numero1 > numero2)
            {
                if (numero1 > numero3)

                    Console.Write(numero1);
            }


            else if (numero2 > numero3)
            {

                if (numero2 > numero1)

                    Console.Write(numero2);




                else
                {
                    Console.WriteLine(numero3);
                }
            }
        }
    }
}

