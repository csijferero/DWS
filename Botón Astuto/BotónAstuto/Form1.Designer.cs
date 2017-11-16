namespace BotónAstuto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quieres que te ponga directamente un 10 en DWS?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNO
            // 
            this.btnNO.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.Location = new System.Drawing.Point(336, 135);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(96, 64);
            this.btnNO.TabIndex = 4;
            this.btnNO.Text = "NO";
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            this.btnNO.MouseLeave += new System.EventHandler(this.btnNO_MouseLeave);
            // 
            // btnSi
            // 
            this.btnSi.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.Location = new System.Drawing.Point(160, 135);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(96, 64);
            this.btnSi.TabIndex = 3;
            this.btnSi.Text = "SI";
            this.btnSi.MouseEnter += new System.EventHandler(this.btnSi_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Botón Astuto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNO;
    }
}

