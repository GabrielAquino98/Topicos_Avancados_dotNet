using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{
    class Frutas
    {
        string nome;
        int id;
        string descricao;
        int qtd;

        public Frutas()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public string Nome { get => nome; set => nome = value; }

    }
}
