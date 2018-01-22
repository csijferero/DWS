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
    public partial class Pagina3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.PreviousPage != null)
            {
                TextBox miTextBox1 = (TextBox)Page.PreviousPage.FindControl("txb1");
                TextBox miTextBox2 = Page.PreviousPage.FindControl("txb2") as TextBox; // <-- Otra forma de hacer casting

                lbResultado.Text = miTextBox1.Text + "  +  " + miTextBox2.Text;
            }
        }
    }
}
