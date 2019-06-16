using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEmprestimo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Emprestimo emp = new Emprestimo()
            {
                Descricao = txtDescricao.Text,
                Valor = Convert.ToDouble(txtValor.Text),
                Dt_emprestimo = calendar.SelectedDate,
                Juros = Convert.ToDouble(txtJuros.Text),
                Qtd_parcela = Convert.ToInt16(txtQtdParcelas)
            };
        }
    }
}