namespace InterfazUsuario
{
    partial class IUDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbConductor = new System.Windows.Forms.ToolStripButton();
            this.tsbCarrera = new System.Windows.Forms.ToolStripButton();
            this.tsbTarifa = new System.Windows.Forms.ToolStripButton();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.fotoCabecera = new System.Windows.Forms.PictureBox();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCabecera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LawnGreen;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Del});
            this.dgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(12, 294);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(994, 188);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(110, 110);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCliente,
            this.tsbConductor,
            this.tsbCarrera,
            this.tsbTarifa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1018, 131);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbCliente
            // 
            this.tsbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCliente.ForeColor = System.Drawing.Color.Blue;
            this.tsbCliente.Image = global::InterfazUsuario.Properties.Resources.person_user_customer_man_male_man_boy_people_1687;
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(114, 128);
            this.tsbCliente.Text = "Clientes";
            this.tsbCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCliente.Click += new System.EventHandler(this.tsbCliente_Click);
            // 
            // tsbConductor
            // 
            this.tsbConductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbConductor.ForeColor = System.Drawing.Color.Blue;
            this.tsbConductor.Image = global::InterfazUsuario.Properties.Resources.taxi_18540;
            this.tsbConductor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConductor.Name = "tsbConductor";
            this.tsbConductor.Size = new System.Drawing.Size(114, 128);
            this.tsbConductor.Text = "Conductores";
            this.tsbConductor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConductor.Click += new System.EventHandler(this.tsbConductor_Click);
            // 
            // tsbCarrera
            // 
            this.tsbCarrera.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCarrera.ForeColor = System.Drawing.Color.Blue;
            this.tsbCarrera.Image = global::InterfazUsuario.Properties.Resources.Ticket_icon_icons_com_54128;
            this.tsbCarrera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCarrera.Name = "tsbCarrera";
            this.tsbCarrera.Size = new System.Drawing.Size(114, 128);
            this.tsbCarrera.Tag = "";
            this.tsbCarrera.Text = "Carreras";
            this.tsbCarrera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCarrera.Click += new System.EventHandler(this.tsbCarrera_Click);
            // 
            // tsbTarifa
            // 
            this.tsbTarifa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbTarifa.ForeColor = System.Drawing.Color.Blue;
            this.tsbTarifa.Image = global::InterfazUsuario.Properties.Resources.construction_project_plan_building_architect_design_develop_73_icon_icons_com_60243;
            this.tsbTarifa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTarifa.Name = "tsbTarifa";
            this.tsbTarifa.Size = new System.Drawing.Size(114, 128);
            this.tsbTarifa.Text = "Tarifas";
            this.tsbTarifa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTarifa.Click += new System.EventHandler(this.tsbTarifa_Click);
            // 
            // lblBase
            // 
            this.lblBase.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBase.Location = new System.Drawing.Point(243, 126);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(530, 71);
            this.lblBase.TabIndex = 4;
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = global::InterfazUsuario.Properties.Resources.Data_settings_theapplication_3364;
            this.btnUser.Location = new System.Drawing.Point(876, 134);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(142, 154);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Administrar Usuarios";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.AutoSize = true;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Image = global::InterfazUsuario.Properties.Resources.new_file_40454;
            this.btnAñadir.Location = new System.Drawing.Point(0, 134);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(134, 154);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir Registro";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // fotoCabecera
            // 
            this.fotoCabecera.Image = global::InterfazUsuario.Properties.Resources.taxi_sign_wallpaper_3202_1;
            this.fotoCabecera.Location = new System.Drawing.Point(238, 9);
            this.fotoCabecera.Name = "fotoCabecera";
            this.fotoCabecera.Size = new System.Drawing.Size(540, 114);
            this.fotoCabecera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fotoCabecera.TabIndex = 2;
            this.fotoCabecera.TabStop = false;
            // 
            // Del
            // 
            this.Del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Del.HeaderText = "Del";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            this.Del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Del.Text = "X";
            this.Del.ToolTipText = "Eliminar";
            this.Del.UseColumnTextForButtonValue = true;
            this.Del.Visible = false;
            this.Del.Width = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // IUDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1018, 493);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.fotoCabecera);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "IUDatos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCabecera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripButton tsbConductor;
        private System.Windows.Forms.ToolStripButton tsbTarifa;
        private System.Windows.Forms.ToolStripButton tsbCarrera;
        private System.Windows.Forms.PictureBox fotoCabecera;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
        private System.Windows.Forms.TextBox textBox1;
    }
}

