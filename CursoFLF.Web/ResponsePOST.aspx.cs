using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CursoFLF.Web
{
    public partial class ResponsePOST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg1.Text = Request.Form["ctl00$MainContent$txtMensagem1"];
            lblMsg2.Text = Request.Form["ctl00$MainContent$txtMensagem2"];
        }
    }
}