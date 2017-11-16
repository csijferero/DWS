namespace W11_SenoideWin
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
            this.trkbAmplitud = new System.Windows.Forms.TrackBar();
            this.nudCiclos = new System.Windows.Forms.NumericUpDown();
            this.nudDesfase = new System.Windows.Forms.NumericUpDown();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lbCiclos = new System.Windows.Forms.Label();
            this.lbDesfase = new System.Windows.Forms.Label();
            this.lbOffset = new System.Windows.Forms.Label();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.groupBoxTrazo = new System.Windows.Forms.GroupBox();
            this.lbColorTrazo = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbGrosor = new System.Windows.Forms.Label();
            this.groupBoxFondo = new System.Windows.Forms.GroupBox();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lbAmplitud = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbTrack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.groupBoxTrazo.SuspendLayout();
            this.groupBoxFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkbAmplitud
            // 
            this.trkbAmplitud.LargeChange = 10;
            this.trkbAmplitud.Location = new System.Drawing.Point(3, 28);
            this.trkbAmplitud.Maximum = 400;
            this.trkbAmplitud.Name = "trkbAmplitud";
            this.trkbAmplitud.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkbAmplitud.Size = new System.Drawing.Size(45, 225);
            this.trkbAmplitud.TabIndex = 0;
            this.trkbAmplitud.Scroll += new System.EventHandler(this.trkbAmplitud_Scroll);
            // 
            // nudCiclos
            // 
            this.nudCiclos.DecimalPlaces = 1;
            this.nudCiclos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCiclos.Location = new System.Drawing.Point(11, 302);
            this.nudCiclos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCiclos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCiclos.Name = "nudCiclos";
            this.nudCiclos.Size = new System.Drawing.Size(58, 20);
            this.nudCiclos.TabIndex = 1;
            this.nudCiclos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDesfase
            // 
            this.nudDesfase.Location = new System.Drawing.Point(12, 373);
            this.nudDesfase.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudDesfase.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudDesfase.Name = "nudDesfase";
            this.nudDesfase.Size = new System.Drawing.Size(58, 20);
            this.nudDesfase.TabIndex = 2;
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(12, 437);
            this.nudOffset.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(58, 20);
            this.nudOffset.TabIndex = 3;
            // 
            // lbCiclos
            // 
            this.lbCiclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiclos.Location = new System.Drawing.Point(8, 276);
            this.lbCiclos.Name = "lbCiclos";
            this.lbCiclos.Size = new System.Drawing.Size(68, 23);
            this.lbCiclos.TabIndex = 4;
            this.lbCiclos.Text = "Nº Ciclos";
            this.lbCiclos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDesfase
            // 
            this.lbDesfase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesfase.Location = new System.Drawing.Point(5, 345);
            this.lbDesfase.Name = "lbDesfase";
            this.lbDesfase.Size = new System.Drawing.Size(76, 23);
            this.lbDesfase.TabIndex = 5;
            this.lbDesfase.Text = "Nº Desfase";
            this.lbDesfase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOffset
            // 
            this.lbOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffset.Location = new System.Drawing.Point(9, 411);
            this.lbOffset.Name = "lbOffset";
            this.lbOffset.Size = new System.Drawing.Size(61, 23);
            this.lbOffset.TabIndex = 6;
            this.lbOffset.Text = "Offset";
            this.lbOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbGrosor
            // 
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Location = new System.Drawing.Point(11, 52);
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(121, 28);
            this.cbGrosor.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(784, 432);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(781, 466);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(83, 32);
            this.btnDibujar.TabIndex = 9;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // groupBoxTrazo
            // 
            this.groupBoxTrazo.Controls.Add(this.lbColorTrazo);
            this.groupBoxTrazo.Controls.Add(this.lbColor);
            this.groupBoxTrazo.Controls.Add(this.lbGrosor);
            this.groupBoxTrazo.Controls.Add(this.cbGrosor);
            this.groupBoxTrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTrazo.Location = new System.Drawing.Point(742, 12);
            this.groupBoxTrazo.Name = "groupBoxTrazo";
            this.groupBoxTrazo.Size = new System.Drawing.Size(154, 170);
            this.groupBoxTrazo.TabIndex = 10;
            this.groupBoxTrazo.TabStop = false;
            this.groupBoxTrazo.Text = "Trazo";
            // 
            // lbColorTrazo
            // 
            this.lbColorTrazo.BackColor = System.Drawing.Color.Black;
            this.lbColorTrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColorTrazo.Location = new System.Drawing.Point(38, 124);
            this.lbColorTrazo.Name = "lbColorTrazo";
            this.lbColorTrazo.Size = new System.Drawing.Size(68, 23);
            this.lbColorTrazo.TabIndex = 14;
            this.lbColorTrazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbColorTrazo.Click += new System.EventHandler(this.lbColorTrazo_Click);
            // 
            // lbColor
            // 
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(38, 96);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(68, 23);
            this.lbColor.TabIndex = 13;
            this.lbColor.Text = "Color";
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGrosor
            // 
            this.lbGrosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrosor.Location = new System.Drawing.Point(38, 26);
            this.lbGrosor.Name = "lbGrosor";
            this.lbGrosor.Size = new System.Drawing.Size(68, 23);
            this.lbGrosor.TabIndex = 12;
            this.lbGrosor.Text = "Grosor";
            this.lbGrosor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxFondo
            // 
            this.groupBoxFondo.Controls.Add(this.rbAzul);
            this.groupBoxFondo.Controls.Add(this.rbVerde);
            this.groupBoxFondo.Controls.Add(this.rbRojo);
            this.groupBoxFondo.Controls.Add(this.rbNegro);
            this.groupBoxFondo.Controls.Add(this.rbBlanco);
            this.groupBoxFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFondo.Location = new System.Drawing.Point(742, 218);
            this.groupBoxFondo.Name = "groupBoxFondo";
            this.groupBoxFondo.Size = new System.Drawing.Size(154, 196);
            this.groupBoxFondo.TabIndex = 11;
            this.groupBoxFondo.TabStop = false;
            this.groupBoxFondo.Text = "Fondo";
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbAzul.Location = new System.Drawing.Point(35, 145);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(62, 24);
            this.rbAzul.TabIndex = 4;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = false;
            this.rbAzul.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.BackColor = System.Drawing.Color.Lime;
            this.rbVerde.Location = new System.Drawing.Point(35, 115);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(75, 24);
            this.rbVerde.TabIndex = 3;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = false;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.BackColor = System.Drawing.Color.Red;
            this.rbRojo.Location = new System.Drawing.Point(35, 85);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(64, 24);
            this.rbRojo.TabIndex = 2;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = false;
            this.rbRojo.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.BackColor = System.Drawing.Color.Black;
            this.rbNegro.ForeColor = System.Drawing.Color.White;
            this.rbNegro.Location = new System.Drawing.Point(35, 55);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(75, 24);
            this.rbNegro.TabIndex = 1;
            this.rbNegro.TabStop = true;
            this.rbNegro.Text = "Negro";
            this.rbNegro.UseVisualStyleBackColor = false;
            this.rbNegro.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.BackColor = System.Drawing.Color.White;
            this.rbBlanco.Location = new System.Drawing.Point(35, 25);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(82, 24);
            this.rbBlanco.TabIndex = 0;
            this.rbBlanco.TabStop = true;
            this.rbBlanco.Text = "Blanco";
            this.rbBlanco.UseVisualStyleBackColor = false;
            this.rbBlanco.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // panelDibujo
            // 
            this.panelDibujo.Location = new System.Drawing.Point(87, 12);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(649, 486);
            this.panelDibujo.TabIndex = 12;
            // 
            // lbAmplitud
            // 
            this.lbAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmplitud.Location = new System.Drawing.Point(42, 228);
            this.lbAmplitud.Name = "lbAmplitud";
            this.lbAmplitud.Size = new System.Drawing.Size(34, 23);
            this.lbAmplitud.TabIndex = 13;
            this.lbAmplitud.Text = "0";
            this.lbAmplitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTrack
            // 
            this.lbTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrack.Location = new System.Drawing.Point(6, 9);
            this.lbTrack.Name = "lbTrack";
            this.lbTrack.Size = new System.Drawing.Size(68, 23);
            this.lbTrack.TabIndex = 14;
            this.lbTrack.Text = "Amplitud";
            this.lbTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 510);
            this.Controls.Add(this.lbTrack);
            this.Controls.Add(this.lbAmplitud);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.groupBoxFondo);
            this.Controls.Add(this.groupBoxTrazo);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lbOffset);
            this.Controls.Add(this.lbDesfase);
            this.Controls.Add(this.lbCiclos);
            this.Controls.Add(this.nudOffset);
            this.Controls.Add(this.nudDesfase);
            this.Controls.Add(this.nudCiclos);
            this.Controls.Add(this.trkbAmplitud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.groupBoxTrazo.ResumeLayout(false);
            this.groupBoxFondo.ResumeLayout(false);
            this.groupBoxFondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkbAmplitud;
        private System.Windows.Forms.NumericUpDown nudCiclos;
        private System.Windows.Forms.NumericUpDown nudDesfase;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Label lbCiclos;
        private System.Windows.Forms.Label lbDesfase;
        private System.Windows.Forms.Label lbOffset;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.GroupBox groupBoxTrazo;
        private System.Windows.Forms.Label lbColorTrazo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbGrosor;
        private System.Windows.Forms.GroupBox groupBoxFondo;
        private System.Windows.Forms.RadioButton rbAzul;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label lbAmplitud;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbTrack;
    }
}

