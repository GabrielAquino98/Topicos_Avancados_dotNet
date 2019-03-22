using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Cliente : Pessoa
    {

        #region Propriedades
        public GrauSatisfacao GrauSatisfacao { get; set; }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return base.ToString() +"\nGrau de Satisfação: "+ this.GrauSatisfacao.Descricao
                                   +"\nId Ggrau de Satisfação: "+this.GrauSatisfacao.Id;
        }
        #endregion

    }
}
