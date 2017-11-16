namespace GridView_a_Lista
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbAnadidos = new System.Windows.Forms.Label();
            this.clbAnadidos = new System.Windows.Forms.CheckedListBox();
            this.btnCargarFichero = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbPuntos = new System.Windows.Forms.RadioButton();
            this.gbOrdenacion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbOrdenacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAnadidos
            // 
            this.lbAnadidos.AutoSize = true;
            this.lbAnadidos.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnadidos.Location = new System.Drawing.Point(51, 79);
            this.lbAnadidos.Name = "lbAnadidos";
            this.lbAnadidos.Size = new System.Drawing.Size(88, 16);
            this.lbAnadidos.TabIndex = 11;
            this.lbAnadidos.Text = "Añadidos: ";
            // 
            // clbAnadidos
            // 
            this.clbAnadidos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAnadidos.FormattingEnabled = true;
            this.clbAnadidos.Location = new System.Drawing.Point(33, 102);
            this.clbAnadidos.Name = "clbAnadidos";
            this.clbAnadidos.Size = new System.Drawing.Size(302, 310);
            this.clbAnadidos.TabIndex = 10;
            // 
            // btnCargarFichero
            // 
            this.btnCargarFichero.Location = new System.Drawing.Point(33, 28);
            this.btnCargarFichero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarFichero.Name = "btnCargarFichero";
            this.btnCargarFichero.Size = new System.Drawing.Size(203, 39);
            this.btnCargarFichero.TabIndex = 9;
            this.btnCargarFichero.Text = "Cargar desde fichero";
            this.btnCargarFichero.UseVisualStyleBackColor = true;
            this.btnCargarFichero.Click += new System.EventHandler(this.btnCargarFichero_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(369, 102);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(451, 310);
            this.dgv.TabIndex = 12;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Edit";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "►";
            this.Editar.ToolTipText = "Editar registro";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 54;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Archivo de texto";
            this.openFileDialog.Filter = "Archivo de texto|*.txt*|Todos los archivos|*.*";
            this.openFileDialog.InitialDirectory = ".\\Datos";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(33, 418);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(114, 31);
            this.btnRecargar.TabIndex = 15;
            this.btnRecargar.Text = "Recargar esta lista";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(38, 22);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(67, 20);
            this.rbNombre.TabIndex = 16;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbPuntos
            // 
            this.rbPuntos.AutoSize = true;
            this.rbPuntos.Location = new System.Drawing.Point(125, 22);
            this.rbPuntos.Name = "rbPuntos";
            this.rbPuntos.Size = new System.Drawing.Size(64, 20);
            this.rbPuntos.TabIndex = 17;
            this.rbPuntos.Text = "Puntos";
            this.rbPuntos.UseVisualStyleBackColor = true;
            this.rbPuntos.CheckedChanged += new System.EventHandler(this.rbPuntos_CheckedChanged);
            // 
            // gbOrdenacion
            // 
            this.gbOrdenacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbOrdenacion.Controls.Add(this.rbNombre);
            this.gbOrdenacion.Controls.Add(this.rbPuntos);
            this.gbOrdenacion.Enabled = false;
            this.gbOrdenacion.Location = new System.Drawing.Point(393, 43);
            this.gbOrdenacion.Name = "gbOrdenacion";
            this.gbOrdenacion.Size = new System.Drawing.Size(336, 52);
            this.gbOrdenacion.TabIndex = 18;
            this.gbOrdenacion.TabStop = false;
            this.gbOrdenacion.Text = "Ordenado por";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 475);
            this.Controls.Add(this.gbOrdenacion);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbAnadidos);
            this.Controls.Add(this.clbAnadidos);
            this.Controls.Add(this.btnCargarFichero);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbOrdenacion.ResumeLayout(false);
            this.gbOrdenacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnadidos;
        private System.Windows.Forms.CheckedListBox clbAnadidos;
        private System.Windows.Forms.Button btnCargarFichero;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbPuntos;
        private System.Windows.Forms.GroupBox gbOrdenacion;
    }
}

