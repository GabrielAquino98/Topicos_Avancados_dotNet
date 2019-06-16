using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atividade
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGerar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                lblTabuada.Text = lblTabuada.Text + "<h4>\n2 x " + i + " = " + 2 * i +"</h4>";
            }
        }
    }
}