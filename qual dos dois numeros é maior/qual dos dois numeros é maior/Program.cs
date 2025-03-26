using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qual_dos_dois_numeros_é_maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, total;


                    Console.WriteLine("digite o primeiro numero desejado ");
                   numero1 = Convert.ToDouble(Console.ReadLine());
                 Console.WriteLine("digite o primeiro numero desejado "); ;
                numero2 = Convert.ToDouble(Console.ReadLine());

              if(numero1 > numero2)
                Console.WriteLine("nemero 1 é maior que numero 2");
                 else{ Console.WriteLine("numero 2 é maior que numero 1");
            
            }
        }
    }
}
