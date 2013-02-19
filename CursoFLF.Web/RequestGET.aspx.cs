using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoFLF.Web
{
    public partial class RequestGET : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ResponseGET.aspx?msg1=" + txtMensagem1.Text + "&msg2=" + txtMensagem2.Text);
        }
    }
}