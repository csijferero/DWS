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
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // se pueden capturar los valores de cualquiera de estas dos formas
            //lbResultado.Text = Request.QueryString["texto1"] + " " + Request.QueryString["texto2"]; 
            
            lbResultado.Text = Request.Params.Get("texto1") + " + " + Request.Params.Get("texto2");
        }
    }
}
