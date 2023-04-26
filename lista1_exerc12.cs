using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1;
            double produto2;
            double produto3;
            double produto4;
            double produto5;
            double produtototal;
            double pagamento;
            double troco;
            Console.WriteLine("Cálculo de troco");
            Console.Write("\nInsira o valor do 1º produto: ");
            produto1 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor do 2º produto: ");
            produto2 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor do 3º produto: ");
            produto3 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor do 4º produto: ");
            produto4 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o valor do 5º produto: ");
            produto5 = double.Parse(Console.ReadLine());
            produtototal = produto1 + produto2 + produto3 + produto4 + produto5;
            Console.Write("\nValor total da compra foi de {0}. Insira o valor do pagamento: ", produtototal);
            pagamento = double.Parse(Console.ReadLine());
            troco = pagamento - produtototal;
            Console.WriteLine("\nO troco é de: {0}\n", troco);
        }
    }
}
