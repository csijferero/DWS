namespace InterfazUsuario
{
    partial class EditConductor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelDNI = new System.Windows.Forms.Label();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.labelLicencia = new System.Windows.Forms.Label();
            this.txbLicencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(152, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(556, 65);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(440, 118);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(29, 13);
            this.labelDNI.TabIndex = 46;
            this.labelDNI.Text = "DNI";
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(633, 118);
            this.txbDNI.MaxLength = 10;
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(155, 20);
            this.txbDNI.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(21, 118);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 45;
            this.labelEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(214, 118);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(155, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(440, 21);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(61, 13);
            this.labelDireccion.TabIndex = 42;
            this.labelDireccion.Text = "Direccion";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(633, 21);
            this.txbDireccion.MaxLength = 50;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(155, 20);
            this.txbDireccion.TabIndex = 1;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(440, 67);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(58, 13);
            this.labelApellidos.TabIndex = 41;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(21, 67);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 40;
            this.labelNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(214, 67);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(155, 20);
            this.txbNombre.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(21, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 13);
            this.labelID.TabIndex = 37;
            this.labelID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(214, 18);
            this.txbID.MaxLength = 2;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(35, 20);
            this.txbID.TabIndex = 35;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(633, 67);
            this.txbApellidos.MaxLength = 50;
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(155, 20);
            this.txbApellidos.TabIndex = 3;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(440, 176);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(59, 13);
            this.labelMatricula.TabIndex = 50;
            this.labelMatricula.Text = "Matricula";
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(633, 176);
            this.txbMatricula.MaxLength = 7;
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(155, 20);
            this.txbMatricula.TabIndex = 7;
            // 
            // labelLicencia
            // 
            this.labelLicencia.AutoSize = true;
            this.labelLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicencia.Location = new System.Drawing.Point(21, 176);
            this.labelLicencia.Name = "labelLicencia";
            this.labelLicencia.Size = new System.Drawing.Size(55, 13);
            this.labelLicencia.TabIndex = 48;
            this.labelLicencia.Text = "Licencia";
            // 
            // txbLicencia
            // 
            this.txbLicencia.Location = new System.Drawing.Point(214, 176);
            this.txbLicencia.MaxLength = 4;
            this.txbLicencia.Name = "txbLicencia";
            this.txbLicencia.Size = new System.Drawing.Size(155, 20);
            this.txbLicencia.TabIndex = 6;
            // 
            // EditConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 307);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.labelLicencia);
            this.Controls.Add(this.txbLicencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.txbApellidos);
            this.Name = "EditConductor";
            this.Text = "EditConductor";
            this.Load += new System.EventHandler(this.EditConductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label labelLicencia;
        private System.Windows.Forms.TextBox txbLicencia;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbApellidos;
    }
}