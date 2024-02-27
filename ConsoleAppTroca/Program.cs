using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTroca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fale o valor inteiro A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Fale o valor inteiro B: ");
            int b = int.Parse(Console.ReadLine());

            int c = b;

            int b = a;

            int a = c;

            Console.WriteLine("Valor de A: " + A + " Valor de B:" + B);

            Console.ReadKey();
        }
    }
}
