using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleicao
{
    class Program
    {
        static void Main(string[] args)
        {

            int total, nulo, branco, valido = 0;

            do {
                
                Console.WriteLine("Informe o total de eleitores do municipio: ");
                total = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de votos nulo: ");
                nulo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de votos branco: ");
                branco = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de votos validos: ");
                valido = Convert.ToInt32(Console.ReadLine());

                if ((branco + nulo + valido) != total)
                {
                    Console.WriteLine("Numero de votos maior que o total de eleitores");
                }else if(total == 0)
                {
                    Console.WriteLine("Total de eleitores nao pode ser igual a 0");
                }

            } while (((branco+nulo+valido) != total) || total == 0);

            Console.WriteLine("***** PORCENTAGEM DE VOTOS *****");
            Console.WriteLine("TOTAL DE ELEITORES NO MUNICIPIO: " + total);
            Console.WriteLine("Nulos: %" + ((nulo * 100) / total));
            Console.WriteLine("Brancos: %" + ((branco * 100) / total));
            Console.WriteLine("Validos: %" + ((valido * 100) / total));


            Console.ReadKey();
        }

        
    }
}
