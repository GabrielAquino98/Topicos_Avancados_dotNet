using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();


            for (int i =0; i < 3; i++)
            {
                Console.WriteLine("Informe o "+ (i+1) +" valor");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Maior valor: ");
            Console.WriteLine(numeros.Max());

            Console.ReadKey();
        }
    }
}
