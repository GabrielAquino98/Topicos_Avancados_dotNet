using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> produtos = new List<Produtos>();

            double soma = 0, maior = 0;

            for(int i =0; i<15; i++)
            {
                Produtos p = new Produtos();

                Console.WriteLine("Informe o codigo do " +(i+1)+" produto: ");
                p.codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o preco do " + (i + 1) + " produto: ");
                p.preco = Convert.ToDouble(Console.ReadLine());

                if(p.preco > maior)
                {
                    maior = p.preco;
                }

                soma = soma + p.preco;

                produtos.Add(p);
            }

            Console.WriteLine("Maior preco: " + maior);
            Console.WriteLine("Media dos precos: " + (soma / 15));

            Console.ReadKey();

        }
    }

    internal class Produtos
    {
        public int codigo;
        public double preco;

        public Produtos(int codigo, double preco)
        {
            this.codigo = codigo;
            this.preco = preco;
        }

        public Produtos()
        {

        }
    }
}
