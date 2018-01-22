using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace DEMO_2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResponse_Click(object sender, EventArgs e)
        {
            // se puede hacer como en el ejemplo de los apuntes
            Response.Redirect("Pagina2.aspx?texto1=" + txb1.Text + "&texto2=" + txb2.Text);
            // o de esta forma que me parece más cómoda
            Response.Redirect(String.Format("Pagina2.aspx?texto1={0}&texto2={1}", txb1.Text, txb2.Text));
        }
 
        protected void btnCross_Click(object sender, EventArgs e)
        {
            // Response.Redirect("Pagina3.aspx");
            txb2.Text = txb2.Text.ToUpper(); // <-- Por hacer algo
        }
    }
}
