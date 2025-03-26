using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peixeriadokjapofp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, sobra;
            Console.WriteLine("digite o peso do peixe");
             peso = double.Parse(Console.ReadLine());
              sobra = (peso - 50) * 4;
            Console.WriteLine(sobra);
        }
    }
}
