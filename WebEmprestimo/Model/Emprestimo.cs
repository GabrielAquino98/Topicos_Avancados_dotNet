using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Emprestimo
    {

        #region Propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Dt_emprestimo { get; set; }
        public double Juros { get; set; }
        public int Qtd_parcela { get; set; }
        #endregion
    }
}
