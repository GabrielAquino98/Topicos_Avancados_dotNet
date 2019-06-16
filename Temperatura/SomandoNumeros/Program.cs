using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomandoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();   

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "º numero: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Soma dos numeros: " + numeros.Sum());

            Console.ReadKey();
        }
    }
}
