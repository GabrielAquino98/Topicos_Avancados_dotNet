using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImpostoCarroZero
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal custo = 0;

            Console.WriteLine("Informe o custo total da fabrica na fabricacao do veiculo: ");
            custo = Convert.ToDecimal(Console.ReadLine());
            decimal custoFinal = ((custo * 28) / 100) + ((custo * 45) / 100) + custo;
            Console.WriteLine("Custo com impostos para o consumidor: "+ custoFinal);
            Console.ReadKey();
        }
    }
}
