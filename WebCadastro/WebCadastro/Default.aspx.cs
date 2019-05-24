using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCadastro
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };

            if(new PessoaDB().Insert(pessoa))
            {
                lblMsg.Text = "Registro Inserido!";
                lblMsg.ForeColor = Color.Blue;
                ReloadGrid();
            }
            else
            {
                lblMsg.Text = "Erro ao inserir registro!";
                lblMsg.ForeColor = Color.Red;
                ReloadGrid();
            }
        }

        private void ReloadGrid()
        {
            GVPessoa.DataSource = new PessoaDB().All();
            GVPessoa.DataBind();
        }

    }
}