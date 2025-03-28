
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Double temperatura;

            Console.Write("Digite a temperatura em Celcius: ");
            temperatura = new Double();


            if (temperatura < 15) {
                Console.WriteLine("Está frio 🥶");
            }
            else if (temperatura >= 15 && temperatura <= 25){
                Console.Write("Está ameno 😎");
            }
            else {
                Console.WriteLine("Está quente 🥵");
            }
        }
    }
}
