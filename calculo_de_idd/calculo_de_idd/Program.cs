using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_de_idd
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            int ano_nascimento, ano_atual, Idade;
           //int decalara a variavel inteiro 
            Console.WriteLine("Digite o ano do seu nascimento: ");
            //console.weite =escreva 
             ano_nascimento = int.Parse(Console.ReadLine());     
            
              Console.WriteLine("Digite o ano atual: ");
               ano_atual = int.Parse(Console.ReadLine());
            //int perse converte texto em numero 
                Idade = ano_atual - ano_nascimento;
                  Console.WriteLine("Sua Idade é " + Idade + " anos");
        }
    }
}
