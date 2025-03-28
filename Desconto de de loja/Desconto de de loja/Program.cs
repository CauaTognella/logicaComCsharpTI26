using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_de_de_loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double precoProduto, descontoPreco;


            Console.Write("Digite o preço do produto: ");
    precoProduto = Double.Parse(Console.ReadLine());

    if(precoProduto > 100)
    {
                descontoPreco = precoProduto * 0.10;
                Console.Write(descontoPreco + " reais de desconto");
    }
           else
    {
                descontoPreco = precoProduto * 0.5;
                Console.Write(descontoPreco + " reais de desconto");
    }

        }
    }
}
    



