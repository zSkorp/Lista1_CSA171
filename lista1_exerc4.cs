using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseT;
            double alturaT;
            double areaT;
            Console.WriteLine("Área do triângulo");
            Console.Write("\nInsira o valor da base do triângulo: ");
            baseT = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor da altura do triângulo: ");
            alturaT = double.Parse(Console.ReadLine());
            areaT = (baseT * alturaT) / 2;
            Console.WriteLine("\nA área do triângulo é: {0}", areaT);
        }
    }
}
