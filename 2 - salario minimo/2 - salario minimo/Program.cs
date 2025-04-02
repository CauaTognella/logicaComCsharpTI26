using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___salario_minimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse 
            usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).*/

            double sla, slam, qnt;
            Console.WriteLine("digite seu salario: ");
             sla = double.Parse (Console.ReadLine());
              slam = 1518;
               qnt = sla / slam;
                 Console.WriteLine("sua quantidade de salarios minimos é: "+ qnt);

        }
    }
}
