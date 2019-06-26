using System;

namespace Model
{
    public class Produto
    {


        #region
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Qtd { get; set; }
        public double Valor { get; set; }
        #endregion

        public override string ToString()
        {
            return this.Descricao;
        }

        
    }
}
