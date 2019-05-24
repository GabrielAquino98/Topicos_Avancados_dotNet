using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Parcela
    {

        #region Propriedades
        public int Id { get; set; }
        public double Vlr_parcela { get; set; }
        public string Dt_vencto { get; set; }
        public Emprestimo Emprestimo { get; set; }
        #endregion
    }
}
