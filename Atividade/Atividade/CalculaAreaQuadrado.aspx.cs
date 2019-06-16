using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Atividade
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtLado.Text);

            lblArea.Text = "<h3>A area do quadrado é: " + a * a + "</h3>";
            
        }
    }
}