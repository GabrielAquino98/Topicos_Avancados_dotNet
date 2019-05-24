using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data
{
    public class ParcelaDB
    {
        private StringBuilder sb;
        private Conexao conexao;

        public bool Insert(Parcela p)
        {
            try
            {

                sb = new StringBuilder();
                sb.Append("INSERT INTO TB_EMPRESTIMO_GERADO(ID_EMPRESTIMO, VLR_PARCELA, DT_VENCTO) VALUES ");
                sb.Append(string.Format("('{0}', '{1}', '{2}')", p.Emprestimo.Id, p.Vlr_parcela, p.Dt_vencto));

                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sb.ToString());
                }
                return true;
            }
            catch (Exception)
            {

                throw;
                //return false;
            }
        }
    }
}
