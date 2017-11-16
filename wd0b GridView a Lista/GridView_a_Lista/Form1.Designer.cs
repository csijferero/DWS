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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnadidos
            // 
            this.lbAnadidos.AutoSize = true;
            this.lbAnadidos.Location = new System.Drawing.Point(29, 79);
            this.lbAnadidos.Name = "lbAnadidos";
            this.lbAnadidos.Size = new System.Drawing.Size(82, 16);
            this.lbAnadidos.TabIndex = 11;
            this.lbAnadidos.Text = "Añadidos: ";
            // 
            // clbAnadidos
            // 
            this.clbAnadidos.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAnadidos.FormattingEnabled = true;
            this.clbAnadidos.Location = new System.Drawing.Point(33, 102);
            this.clbAnadidos.Name = "clbAnadidos";
            this.clbAnadidos.Size = new System.Drawing.Size(278, 310);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(343, 102);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(450, 310);
            this.dgv.TabIndex = 12;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Archivo de texto";
            this.openFileDialog1.Filter = "Archivo de texto|*.txt*|Todos los archivos|*.*";
            this.openFileDialog1.InitialDirectory = ".\\Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 475);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbAnadidos);
            this.Controls.Add(this.clbAnadidos);
            this.Controls.Add(this.btnCargarFichero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnadidos;
        private System.Windows.Forms.CheckedListBox clbAnadidos;
        private System.Windows.Forms.Button btnCargarFichero;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

