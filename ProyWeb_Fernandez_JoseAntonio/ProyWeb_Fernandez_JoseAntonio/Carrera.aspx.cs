﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LNegocioyADatos;

namespace ProyWeb_Fernandez_JoseAntonio
{
    public partial class Carrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                Usuarios usu = null;
                if (Session["usuario"] != null)
                {
                    usu = (Usuarios)Session["usuario"];
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

                if (usu.AccesoUsuario == 2)
                {
                    btnUser.Enabled = false;
                    btnAñadir.Enabled = false;
                }

                dgv.DataSource = LNyAD.TablaCarreras(); //Llenamos el DataGridView a partir de un DataTable

                dgv.DataBind();
            }
        }

        protected void tsbCliente_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Cliente.aspx");
        }

        protected void tsbConductor_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Conductor.aspx");
        }

        protected void tsbTarifa_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Tarifa.aspx");
        }

        protected void tsbCarrera_Click(object sender, ImageClickEventArgs e)
        {
            dgv.DataSource = LNyAD.TablaCarreras(); //Llenamos el DataGridView a partir de un DataTable

            dgv.DataBind();
        }

        protected void dgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Application["edicion"] = LNyAD.obtenerCarrera(Convert.ToInt32(dgv.Rows[e.NewEditIndex].Cells[1].Text));
            Response.Redirect("EditarCarrera.aspx");
        }
    }
}