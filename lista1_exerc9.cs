using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double raiocirculo;
            double areacirculo;
            Console.WriteLine("Área do Círculo");
            Console.Write("\nEntre com o diâmetro do círculo: ");
            diametro = double.Parse(Console.ReadLine());
            raiocirculo = (diametro / 2);
            areacirculo = Math.PI * Math.Pow(raiocirculo, 2);
            Console.WriteLine("\nA área do círculo é de: {0}\n", areacirculo);
        }
    }
}
