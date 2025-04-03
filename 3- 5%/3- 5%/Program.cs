using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5 %.*/

            double valor, total, tt;
            Console.ForegroundColor = ConsoleColor.DarkYellow
                ;
            Console.WriteLine(@"
      /$$$$$$$  /$$$$$$$$  /$$$$$$     /$$$$$ /$$   /$$  /$$$$$$  /$$$$$$$$ /$$$$$$$$       /$$$$$$$  /$$$$$$$$       /$$$$$$$ /$$   /$$
     | $$__  $$| $$_____/ /$$__  $$   |__  $$| $$  | $$ /$$__  $$|__  $$__/| $$_____/      | $$__  $$| $$_____/      | $$____/|__/  /$$/
     | $$  \ $$| $$      | $$  \ $$      | $$| $$  | $$| $$  \__/   | $$   | $$            | $$  \ $$| $$            | $$          /$$/ 
     | $$$$$$$/| $$$$$   | $$$$$$$$      | $$| $$  | $$|  $$$$$$    | $$   | $$$$$         | $$  | $$| $$$$$         | $$$$$$$    /$$/  
     | $$__  $$| $$__/   | $$__  $$ /$$  | $$| $$  | $$ \____  $$   | $$   | $$__/         | $$  | $$| $$__/         |_____  $$  /$$/   
     | $$  \ $$| $$      | $$  | $$| $$  | $$| $$  | $$ /$$  \ $$   | $$   | $$            | $$  | $$| $$             /$$  \ $$ /$$/    
     | $$  | $$| $$$$$$$$| $$  | $$|  $$$$$$/|  $$$$$$/|  $$$$$$/   | $$   | $$$$$$$$      | $$$$$$$/| $$$$$$$$      |  $$$$$$//$$/  /$$
     |__/  |__/|________/|__/  |__/ \______/  \______/  \______/    |__/   |________/      |_______/ |________/       \______/|__/  |__/
                                                                                                                                   
                                                                                                                                   
                                                                                                                                   
");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
             Console.WriteLine("escreva o numero que deseja saber o reajuste de 5%: ");
                valor = double.Parse(Console.ReadLine());
                 total = 0.05 * valor;
                  tt = total + valor;
                   Console.WriteLine("o valor é: " + tt );

            
        }
    }
}
