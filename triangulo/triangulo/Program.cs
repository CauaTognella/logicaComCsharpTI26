using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double lado1, lado2, lado3;

    Console.Write("Digite um dos lados do triângulo: ");
    lado1 = Double.Parse(args[0]);
            Console.Write("Digite o segundo lado do triângulo: ");
    lado2 = Double.Parse(args[1]);
            Console.Write("Digite o terceiro lado do triângulo: ");
    lado3 = Double.Parse(args[2]);

            if (lado1 == lado2 && lado1 == lado3 || lado2 == lado1 && lado2 == lado3 || lado3 == lado2 && lado3 == lado1) {
                Console.Write("O triângulo é um equilátero.");
            }
            else if(lado1 == lado2 && lado1 != lado3 || lado1 == lado3 && lado1 != lado2 || lado2 == lado1 && lado2 != lado3 || lado2 == lado3 && lado2 != lado1){
                Console.Write("O triângulo é um isósceles.");
            }
            else {
                Console.Write("O triângulo é um escaleno.");
            }
        }
    }
}
