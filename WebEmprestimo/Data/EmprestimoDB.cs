using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Data
{
    public class EmprestimoDB
    {
        private Conexao conexao;

        public bool Insert(Emprestimo e)
        {
            string sql = "INSERT INTO TB_EMPRESTIMO(DESCRICAO, VALOR, DT_EMPRESTIMO, JUROS, QTD_PARCELAS) VALUES("
                + e.Descricao + "," + e.Valor + "," + e.Dt_emprestimo + "," + e.Juros + "," + e.Qtd_parcela + " ;";


            try
            {

                using (conexao = new Conexao())
                {
                    conexao.ExecutaComando(sql);
                }
                return true;
            }
            catch (Exception)
            {

                
                return false;
            }

        }
    }
}
