namespace InterfazUsuario
{
    partial class EditCarreras
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
            this.labelCond = new System.Windows.Forms.Label();
            this.labelTarifa = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.txbDuracion = new System.Windows.Forms.TextBox();
            this.txbDestino = new System.Windows.Forms.TextBox();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.txbOrigen = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbMetros = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labeDestino = new System.Windows.Forms.Label();
            this.labelMetros = new System.Windows.Forms.Label();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.cmbCond = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCond
            // 
            this.labelCond.AutoSize = true;
            this.labelCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCond.Location = new System.Drawing.Point(440, 182);
            this.labelCond.Name = "labelCond";
            this.labelCond.Size = new System.Drawing.Size(65, 13);
            this.labelCond.TabIndex = 67;
            this.labelCond.Text = "Conductor";
            // 
            // labelTarifa
            // 
            this.labelTarifa.AutoSize = true;
            this.labelTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarifa.Location = new System.Drawing.Point(21, 182);
            this.labelTarifa.Name = "labelTarifa";
            this.labelTarifa.Size = new System.Drawing.Size(40, 13);
            this.labelTarifa.TabIndex = 65;
            this.labelTarifa.Text = "Tarifa";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(443, 249);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(345, 65);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracion.Location = new System.Drawing.Point(440, 124);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(51, 13);
            this.labelDuracion.TabIndex = 63;
            this.labelDuracion.Text = "Minutos";
            // 
            // txbDuracion
            // 
            this.txbDuracion.Location = new System.Drawing.Point(633, 124);
            this.txbDuracion.MaxLength = 5;
            this.txbDuracion.Name = "txbDuracion";
            this.txbDuracion.Size = new System.Drawing.Size(155, 20);
            this.txbDuracion.TabIndex = 4;
            // 
            // txbDestino
            // 
            this.txbDestino.Location = new System.Drawing.Point(633, 73);
            this.txbDestino.MaxLength = 50;
            this.txbDestino.Name = "txbDestino";
            this.txbDestino.Size = new System.Drawing.Size(155, 20);
            this.txbDestino.TabIndex = 2;
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigen.Location = new System.Drawing.Point(21, 73);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(44, 13);
            this.labelOrigen.TabIndex = 57;
            this.labelOrigen.Text = "Origen";
            // 
            // txbOrigen
            // 
            this.txbOrigen.Location = new System.Drawing.Point(214, 73);
            this.txbOrigen.MaxLength = 50;
            this.txbOrigen.Name = "txbOrigen";
            this.txbOrigen.Size = new System.Drawing.Size(155, 20);
            this.txbOrigen.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(21, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 13);
            this.labelID.TabIndex = 54;
            this.labelID.Text = "ID";
            this.labelID.Visible = false;
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(214, 24);
            this.txbID.MaxLength = 2;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(35, 20);
            this.txbID.TabIndex = 52;
            this.txbID.Visible = false;
            // 
            // txbMetros
            // 
            this.txbMetros.Location = new System.Drawing.Point(214, 124);
            this.txbMetros.MaxLength = 7;
            this.txbMetros.Name = "txbMetros";
            this.txbMetros.Size = new System.Drawing.Size(155, 20);
            this.txbMetros.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labeDestino
            // 
            this.labeDestino.AutoSize = true;
            this.labeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeDestino.Location = new System.Drawing.Point(440, 73);
            this.labeDestino.Name = "labeDestino";
            this.labeDestino.Size = new System.Drawing.Size(50, 13);
            this.labeDestino.TabIndex = 62;
            this.labeDestino.Text = "Destino";
            // 
            // labelMetros
            // 
            this.labelMetros.AutoSize = true;
            this.labelMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetros.Location = new System.Drawing.Point(21, 124);
            this.labelMetros.Name = "labelMetros";
            this.labelMetros.Size = new System.Drawing.Size(45, 13);
            this.labelMetros.TabIndex = 58;
            this.labelMetros.Text = "Metros";
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(214, 179);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(155, 21);
            this.cmbTarifa.TabIndex = 5;
            // 
            // cmbCond
            // 
            this.cmbCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCond.FormattingEnabled = true;
            this.cmbCond.ItemHeight = 13;
            this.cmbCond.Location = new System.Drawing.Point(633, 182);
            this.cmbCond.Name = "cmbCond";
            this.cmbCond.Size = new System.Drawing.Size(155, 21);
            this.cmbCond.TabIndex = 6;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(633, 23);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(155, 21);
            this.cmbClient.TabIndex = 7;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(440, 23);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 70;
            this.labelClient.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(21, 249);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(42, 13);
            this.labelFecha.TabIndex = 74;
            this.labelFecha.Text = "Fecha";
            // 
            // EditCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 488);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.cmbCond);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.labelCond);
            this.Controls.Add(this.labelTarifa);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.txbDuracion);
            this.Controls.Add(this.txbDestino);
            this.Controls.Add(this.labelOrigen);
            this.Controls.Add(this.txbOrigen);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.txbMetros);
            this.Controls.Add(this.labeDestino);
            this.Controls.Add(this.labelMetros);
            this.Name = "EditCarreras";
            this.Text = "EditCarreras";
            this.Load += new System.EventHandler(this.EditCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCond;
        private System.Windows.Forms.Label labelTarifa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.TextBox txbDuracion;
        private System.Windows.Forms.TextBox txbDestino;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.TextBox txbOrigen;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbMetros;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labeDestino;
        private System.Windows.Forms.Label labelMetros;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox cmbCond;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected internal System.Windows.Forms.ComboBox cmbClient;
    }
}