using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media15A100
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for(int i =15; i<=100; i++)
            {
                numeros.Add(i);
            }

            Console.WriteLine("Media dos numeros de 15 ate 100: " + numeros.Average());

            Console.ReadKey();
        }
    }
}
