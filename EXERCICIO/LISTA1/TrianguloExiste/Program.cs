using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloExiste
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a, b, c = 0;

            Console.WriteLine("Informe o valor do lado A: ");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado B: ");
            b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor do lado C: ");
            c = Convert.ToDecimal(Console.ReadLine());

            if (((a + b) > c) && ((c + b) > a) && ((a + c) > b))
            {
                Console.WriteLine("Triangulo Existe :D");
            }
            else
            {
                Console.WriteLine("Triangulo não existe D:");
            }

            Console.ReadKey();
        }
    }
}
