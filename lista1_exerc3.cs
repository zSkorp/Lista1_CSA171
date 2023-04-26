using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double ladoQuad;
            double areaQuad;
            Console.WriteLine("Área do quadrado de acordo com a diagonal");
            Console.Write("\nDigite a diagonal do quadrado: ");
            diagonal = double.Parse(Console.ReadLine());
            ladoQuad = (diagonal * diagonal) / 2;
            areaQuad = ladoQuad * ladoQuad;
            Console.WriteLine("\nA área do quadrado é de: {0}\n", areaQuad);
        }
    }
}
