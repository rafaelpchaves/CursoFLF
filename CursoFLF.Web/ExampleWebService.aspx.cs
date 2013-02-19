using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CursoFLF.Web.ServiceReference1;

namespace CursoFLF.Web
{
    public partial class ExampleWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Service1SoapClient service1 = new Service1SoapClient();
            lblresultado.Text = service1.Soma(Convert.ToInt32(txtValor1.Text), Convert.ToInt32(txtValor2.Text)).ToString();
        }
    }
}