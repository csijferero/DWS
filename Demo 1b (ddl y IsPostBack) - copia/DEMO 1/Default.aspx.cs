﻿using System;
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

namespace DEMO_1
{
    public partial class _Default : System.Web.UI.Page
    {
        string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlNombres.Items.Add("Joaquín");
                ddlNombres.Items.Add("Adrián");
                ddlNombres.Items.Add("Pablo P.");
                ddlNombres.Items.Add("Alejandro");

                nombre = "Pablo L.";
                txbNombre.Text = nombre;
            }
            // si no entra en el if, (es decir, si es un PostBack) en este momento nombre vale null
            //txbNombre.Text = nombre;
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            Session["Nombre"] = ddlNombres.SelectedItem;
            lbSaludo.Text = "Bienvenido " + (Session["Nombre"]);
            lbSaludo.Visible = true;

            
            //nombre = ddlNombres.SelectedItem.ToString();

            // Si hago la asignación aquí, sí se verá el nombre seleccionado
            //txbNombre.Text = nombre;
        }

        protected void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text.Trim().Length>0 && ddlNombres.Items.FindByText(txbNombre.Text.Trim()) == null)
                ddlNombres.Items.Add(txbNombre.Text);
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error", "alert('El amigo ya está añadido')", true);
            txbNombre.Text = String.Empty;
        }

    }
}
