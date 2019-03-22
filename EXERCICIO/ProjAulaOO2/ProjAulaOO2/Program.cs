using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAulaOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario()
            {
                Id = 1,
            Nome = "Gabriel",
            Salario = 1260,
            Sexo = "Masculino",
            Endereco = "Rua 1",
            Telefone = "16997901419"

            };



            Console.WriteLine(func1);
            Console.ReadKey();
            
        }
    }
}
