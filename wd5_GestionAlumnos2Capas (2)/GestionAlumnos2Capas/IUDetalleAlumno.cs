﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LNegocioyADatos;

namespace InterfazUsuario
{
    public partial class IUDetalleAlumno : Form
    {
        Alumno alum;
        public IUDetalleAlumno()
        {
            InitializeComponent();
        }

        public Alumno Alum
        {
            get
            {
                return alum;
            }

            set
            {
                alum = value;
            }
        }

        private void IUDetalleAlumno_Load(object sender, EventArgs e)
        {
            // si indice es negativo oculto el textBox, en caso contrario lo muestro
            txbIndice.Visible = (alum.IdAlumno >= 0);

            txbIndice.Text = alum.IdAlumno.ToString();
            txbApellNom.Text = alum.ApellidosNombre;
            txbDni.Text = alum.Dni;
            txbMovil.Text = alum.Movil;
            txbTelefono.Text = alum.Telefono;
            txbMail.Text = alum.Email;
            cbGruposDetalle.SelectedValue = alum.IdGrupo;
            if (alum.IdGrupo < 0)
                cbGruposDetalle.Text = "Seleccione un grupo";

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            errorProvider1.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (HayErrorEnFormulario())
                return;


            // actualizo el alumno
            alum.ApellidosNombre = txbApellNom.Text;
            alum.Dni = txbDni.Text;
            alum.Movil = txbMovil.Text;
            alum.Telefono = txbTelefono.Text;
            alum.Email = txbMail.Text;
            alum.IdGrupo = (int)cbGruposDetalle.SelectedValue;

            // Me salgo respondiendo OK
            this.DialogResult = DialogResult.OK;
        }

        private bool HayErrorEnFormulario()
        {
            errorProvider1.Clear();

            string text = "";
            bool error = false;
            string[] tabla = txbApellNom.Text.Split(',');


            if (txbTelefono.Text == String.Empty && txbMovil.Text == String.Empty)
            {
                text += "Debe haber un numero de contacto\n";
                error = true;
            }
            if (cbGruposDetalle.SelectedItem == null)
            {
                text += "Debe seleccionar un grupo\n";
                error = true;
                errorProvider1.SetError(cbGruposDetalle, "Vacio");
            }
            if ((txbMovil.Text.Length != 9 || (txbMovil.Text.Substring(0, 1) != "6" && txbMovil.Text.Substring(0, 1) != "7")) && txbMovil.Text.Length != 0)
            {
                text += "El movil debe tener 9 digitos y empezar por 6 o 7\n";
                error = true;
                errorProvider1.SetError(txbMovil, "Error de formato");
            }
            if ((txbTelefono.Text.Length != 9 || (txbTelefono.Text.Substring(0, 3) != "954" && txbTelefono.Text.Substring(0, 3) != "955")) && txbTelefono.Text.Length != 0)
            {
                text += "El telefono debe tener 9 digitos y empezar por 954 o 955\n";
                error = true;
                errorProvider1.SetError(txbTelefono, "Error de formato");
            }
            if (!Regex.IsMatch(txbMail.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                text += "Formato de correo electronico incorrecto\n";
                error = true;
                errorProvider1.SetError(txbMail, "Error de formato");
            }
            if (txbDni.Text.Length == 10)
            {
                if (txbDni.Text[8] != '-' || (txbDni.Text[9] > 'Z' || txbDni.Text[9] < 'A'))
                {
                    text += "Formato de DNI incorrecto\n";
                    error = true;
                    errorProvider1.SetError(txbDni, "Error de formato");
                }
            }
            else
            {
                text += "Formato de DNI incorrecto\n";
                error = true;
                errorProvider1.SetError(txbDni, "Error de formato");
            }
            if (tabla.Length == 2)
            {
                if (tabla[1][0] != ' ')
                {
                    text += "Formato de appelidos y nombre incorrecto\n";
                    error = true;
                    errorProvider1.SetError(txbApellNom, "Error de formato");
                }
            }
            else
            {
                text += "Formato de apelidos y nombre incorrecto\n";
                error = true;
                errorProvider1.SetError(txbApellNom, "Error de formato");
            }
            if ((txbTelefono.Text == alum.Telefono && txbMovil.Text == alum.Movil && txbMail.Text == alum.Email && txbDni.Text == alum.Dni && txbApellNom.Text == alum.ApellidosNombre && Convert.ToInt32(cbGruposDetalle.SelectedValue) == alum.IdGrupo) && !error)
            {
                text += "No se han realizado cambios";
                error = true;
            }
            if (error)
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return error;
        }
    }
}
