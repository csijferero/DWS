namespace InterfazUsuario
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txbID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.txbAlias = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbAcceso = new System.Windows.Forms.ComboBox();
            this.labelAcceso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelContraseña = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LawnGreen;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Del});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(12, 231);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(834, 188);
            this.dgv.TabIndex = 1;
            this.dgv.TabStop = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Del
            // 
            this.Del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Del.HeaderText = "Del";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Del.Text = "X";
            this.Del.ToolTipText = "Eliminar";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Width = 40;
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(208, 8);
            this.txbID.MaxLength = 2;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(35, 20);
            this.txbID.TabIndex = 1;
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(15, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 13);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "ID";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(15, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(208, 57);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(155, 20);
            this.txbNombre.TabIndex = 2;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlias.Location = new System.Drawing.Point(15, 108);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(34, 13);
            this.labelAlias.TabIndex = 7;
            this.labelAlias.Text = "Alias";
            // 
            // txbAlias
            // 
            this.txbAlias.Location = new System.Drawing.Point(208, 108);
            this.txbAlias.MaxLength = 4;
            this.txbAlias.Name = "txbAlias";
            this.txbAlias.Size = new System.Drawing.Size(155, 20);
            this.txbAlias.TabIndex = 3;
            this.txbAlias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(15, 159);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(50, 13);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Usuario";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(208, 159);
            this.txbLogin.MaxLength = 10;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(155, 20);
            this.txbLogin.TabIndex = 4;
            this.txbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(139, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 65);
            this.btnReset.TabIndex = 10;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Resetear Contraseña";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbAcceso
            // 
            this.cmbAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcceso.FormattingEnabled = true;
            this.cmbAcceso.Location = new System.Drawing.Point(662, 108);
            this.cmbAcceso.Name = "cmbAcceso";
            this.cmbAcceso.Size = new System.Drawing.Size(184, 21);
            this.cmbAcceso.TabIndex = 5;
            // 
            // labelAcceso
            // 
            this.labelAcceso.AutoSize = true;
            this.labelAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcceso.Location = new System.Drawing.Point(524, 111);
            this.labelAcceso.Name = "labelAcceso";
            this.labelAcceso.Size = new System.Drawing.Size(78, 13);
            this.labelAcceso.TabIndex = 12;
            this.labelAcceso.Text = "Tipo Acceso";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(9, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 65);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(524, 152);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(71, 13);
            this.labelContraseña.TabIndex = 14;
            this.labelContraseña.Text = "Contraseña";
            this.labelContraseña.Visible = false;
            // 
            // txbClave
            // 
            this.txbClave.Location = new System.Drawing.Point(691, 152);
            this.txbClave.MaxLength = 10;
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(155, 20);
            this.txbClave.TabIndex = 6;
            this.txbClave.UseSystemPasswordChar = true;
            this.txbClave.Visible = false;
            this.txbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.gpbLogin.Controls.Add(this.btnGuardar);
            this.gpbLogin.Controls.Add(this.btnReset);
            this.gpbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLogin.Location = new System.Drawing.Point(600, 3);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(246, 96);
            this.gpbLogin.TabIndex = 15;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Funciones";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 431);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.labelAcceso);
            this.Controls.Add(this.cmbAcceso);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.txbAlias);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.dgv);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpbLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.TextBox txbAlias;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAcceso;
        private System.Windows.Forms.Label labelAcceso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
    }
}