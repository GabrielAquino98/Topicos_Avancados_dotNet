using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAulaOO2
{
    public class TesteCliente
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Teste Cliente");

            Cliente c1 = new Cliente() {
                Id = 1,
                Nome = "Roberta",
                Endereco = "Rua manezin",
                Telefone = "17328193812",
                Sexo = "Feminino",
                GrauSatisfacao = new GrauSatisfacao
                {
                    Id = 1,
                    Descricao = "Muito bom"
                }


            };

            Console.WriteLine(c1);

            Console.ReadKey();
        }
    }
}
