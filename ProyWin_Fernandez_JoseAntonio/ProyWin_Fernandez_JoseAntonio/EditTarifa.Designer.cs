namespace InterfazUsuario
{
    partial class EditTarifa
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
            this.labelDuracion = new System.Windows.Forms.Label();
            this.txbDuracion = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.labelBandera = new System.Windows.Forms.Label();
            this.labelMetros = new System.Windows.Forms.Label();
            this.txbMetros = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbBandera = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(466, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(306, 65);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracion.Location = new System.Drawing.Point(446, 71);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(98, 13);
            this.labelDuracion.TabIndex = 45;
            this.labelDuracion.Text = "Precio Duracion";
            // 
            // txbDuracion
            // 
            this.txbDuracion.Location = new System.Drawing.Point(639, 71);
            this.txbDuracion.MaxLength = 4;
            this.txbDuracion.Name = "txbDuracion";
            this.txbDuracion.Size = new System.Drawing.Size(155, 20);
            this.txbDuracion.TabIndex = 3;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(446, 25);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(50, 13);
            this.labelNumero.TabIndex = 42;
            this.labelNumero.Text = "Numero";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(639, 25);
            this.txbNumero.MaxLength = 4;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(41, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // labelBandera
            // 
            this.labelBandera.AutoSize = true;
            this.labelBandera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBandera.Location = new System.Drawing.Point(27, 122);
            this.labelBandera.Name = "labelBandera";
            this.labelBandera.Size = new System.Drawing.Size(90, 13);
            this.labelBandera.TabIndex = 41;
            this.labelBandera.Text = "PrecioBandera";
            // 
            // labelMetros
            // 
            this.labelMetros.AutoSize = true;
            this.labelMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetros.Location = new System.Drawing.Point(27, 71);
            this.labelMetros.Name = "labelMetros";
            this.labelMetros.Size = new System.Drawing.Size(85, 13);
            this.labelMetros.TabIndex = 40;
            this.labelMetros.Text = "Precio Metros";
            // 
            // txbMetros
            // 
            this.txbMetros.Location = new System.Drawing.Point(220, 71);
            this.txbMetros.MaxLength = 4;
            this.txbMetros.Name = "txbMetros";
            this.txbMetros.Size = new System.Drawing.Size(155, 20);
            this.txbMetros.TabIndex = 2;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(27, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 13);
            this.labelID.TabIndex = 37;
            this.labelID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(220, 22);
            this.txbID.MaxLength = 2;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(35, 20);
            this.txbID.TabIndex = 35;
            // 
            // txbBandera
            // 
            this.txbBandera.Location = new System.Drawing.Point(220, 122);
            this.txbBandera.MaxLength = 4;
            this.txbBandera.Name = "txbBandera";
            this.txbBandera.Size = new System.Drawing.Size(155, 20);
            this.txbBandera.TabIndex = 4;
            // 
            // EditTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 222);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.txbDuracion);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.labelBandera);
            this.Controls.Add(this.labelMetros);
            this.Controls.Add(this.txbMetros);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.txbBandera);
            this.Name = "EditTarifa";
            this.Text = "EditTarifa";
            this.Load += new System.EventHandler(this.EditTarifa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.TextBox txbDuracion;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label labelBandera;
        private System.Windows.Forms.Label labelMetros;
        private System.Windows.Forms.TextBox txbMetros;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbBandera;
    }
}