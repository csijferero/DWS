namespace GestionAlumnosFP_V1
{
    partial class FormDetalleGrupos
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
            this.btnAceptarGrupo = new System.Windows.Forms.Button();
            this.btnCancelarGrupo = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbIndiceGrupo = new System.Windows.Forms.TextBox();
            this.txbAlias = new System.Windows.Forms.TextBox();
            this.lblAlias = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbDpto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarGrupo
            // 
            this.btnAceptarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptarGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarGrupo.Location = new System.Drawing.Point(22, 230);
            this.btnAceptarGrupo.Name = "btnAceptarGrupo";
            this.btnAceptarGrupo.Size = new System.Drawing.Size(155, 40);
            this.btnAceptarGrupo.TabIndex = 84;
            this.btnAceptarGrupo.Text = "Aceptar";
            this.btnAceptarGrupo.UseVisualStyleBackColor = true;
            this.btnAceptarGrupo.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelarGrupo
            // 
            this.btnCancelarGrupo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelarGrupo.Location = new System.Drawing.Point(183, 230);
            this.btnCancelarGrupo.Name = "btnCancelarGrupo";
            this.btnCancelarGrupo.Size = new System.Drawing.Size(155, 40);
            this.btnCancelarGrupo.TabIndex = 83;
            this.btnCancelarGrupo.Text = "Cancelar";
            this.btnCancelarGrupo.UseVisualStyleBackColor = true;
            this.btnCancelarGrupo.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(441, 94);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(308, 29);
            this.txbNombre.TabIndex = 82;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(441, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 81;
            this.lblNombre.Text = "Nombre";
            // 
            // txbIndiceGrupo
            // 
            this.txbIndiceGrupo.Enabled = false;
            this.txbIndiceGrupo.Location = new System.Drawing.Point(22, 19);
            this.txbIndiceGrupo.Name = "txbIndiceGrupo";
            this.txbIndiceGrupo.ReadOnly = true;
            this.txbIndiceGrupo.Size = new System.Drawing.Size(73, 20);
            this.txbIndiceGrupo.TabIndex = 80;
            this.txbIndiceGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbAlias
            // 
            this.txbAlias.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAlias.Location = new System.Drawing.Point(22, 94);
            this.txbAlias.MaxLength = 5;
            this.txbAlias.Name = "txbAlias";
            this.txbAlias.Size = new System.Drawing.Size(308, 29);
            this.txbAlias.TabIndex = 79;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(22, 73);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(29, 13);
            this.lblAlias.TabIndex = 78;
            this.lblAlias.Text = "Alias";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txbDpto
            // 
            this.txbDpto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDpto.Location = new System.Drawing.Point(441, 153);
            this.txbDpto.MaxLength = 2;
            this.txbDpto.Name = "txbDpto";
            this.txbDpto.Size = new System.Drawing.Size(83, 29);
            this.txbDpto.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Id Departamento";
            // 
            // txbTutor
            // 
            this.txbTutor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTutor.Location = new System.Drawing.Point(22, 153);
            this.txbTutor.MaxLength = 4;
            this.txbTutor.Name = "txbTutor";
            this.txbTutor.Size = new System.Drawing.Size(44, 29);
            this.txbTutor.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Id Tutor";
            // 
            // FormDetalleGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 312);
            this.Controls.Add(this.btnAceptarGrupo);
            this.Controls.Add(this.btnCancelarGrupo);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbIndiceGrupo);
            this.Controls.Add(this.txbAlias);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.txbDpto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTutor);
            this.Controls.Add(this.label2);
            this.Name = "FormDetalleGrupos";
            this.Text = "FormDetalleGrupo";
            this.Load += new System.EventHandler(this.FormDetalleGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarGrupo;
        private System.Windows.Forms.Button btnCancelarGrupo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbIndiceGrupo;
        private System.Windows.Forms.TextBox txbAlias;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txbDpto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTutor;
        private System.Windows.Forms.Label label2;
    }
}