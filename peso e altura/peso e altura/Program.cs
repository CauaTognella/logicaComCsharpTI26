using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peso_e_altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5-	Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, leia o seu peso e sua altura e imprima na tela sua condição 
de acordo com a tabela abaixo:
Fórmula do IMC = peso / (altura) ²
Tabela Condições IMC
  
 Abaixo de 18,5   | Abaixo do peso          
 Entre 18,6 e 24,9 | Peso ideal (parabéns)  
 Entre 25,0 e 29,9 | Levemente acima do peso
 Entre 30,0 e 34,9 | Obesidade grau I 
 Entre 35,0 e 39,9 | Obesidade grau II (severa)
 Maior ou igual a 40 | Obesidade grau III (mórbida)*/

            double peso, altura,PP;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
╔═════════════════════════════════════════════════════╗ 
║                            _     _            _     ║
║                           (_)   | |          | |    ║
║    _ __   ___  ___  ___    _  __| | ___  __ _| |    ║
║   | '_ \ / _ \/ __|/ _ \  | |/ _` |/ _ \/ _` | |    ║
║   | |_) |  __/\__ \ (_) | | | (_| |  __/ (_| | |    ║ 
║   | .__/ \___||___/\___/  |_|\__,_|\___|\__,_|_|    ║
║   | |                                               ║
║   |_|                                               ║
╚═════════════════════════════════════════════════════╝
");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("escreva seu peso: ");
            PP = double.Parse(Console.ReadLine());
            Console.WriteLine("escreva sua altura: ");
            altura = double.Parse(Console.ReadLine()    );
            peso = PP / (altura * altura);
            if (peso < 18.5) {
                Console.WriteLine("vc está abaixo do peso: ");

            }
            if (peso > 18.6 && peso < 24.9) {

                Console.WriteLine("vc está no peso ideal parabén");
                }
            if (peso > 25.0 && peso < 29.0)
            {
                Console.WriteLine("levemente acima do peso: ");
                            }
            if (peso > 30.0 && peso < 34.9)
            {
                Console.WriteLine("obesidade gral 1: ");
            }
            if (peso > 35.0 && peso < 39.9)
            {
                Console.WriteLine("OBESIDADE GRAL 2 (MORBIDA)");
            }
            if (peso >= 40)
            {
                Console.WriteLine("obesidade gral 3 (morbida);" +
                    "VC VAI MORRER ");
            }
            

        }
    }
}
