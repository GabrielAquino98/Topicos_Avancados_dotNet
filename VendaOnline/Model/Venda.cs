using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Venda
    {

        #region
        public int Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int Qtd { get; set; }
        public double ValorTotal { get; set; }
        public string DataVenda { get; set; }
        #endregion
    }
}
