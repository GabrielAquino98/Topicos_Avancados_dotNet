using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Cliente
    {
        #region Propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        #endregion


        public override string ToString()
        {
            return this.Nome;
        }
    }
}
