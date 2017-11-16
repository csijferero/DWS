namespace PW7b_CheckedList
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nomEquipo = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.listaEquipos = new System.Windows.Forms.CheckedListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.chbMulti = new System.Windows.Forms.CheckBox();
            this.chbOrden = new System.Windows.Forms.CheckBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.clickBox = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rdbDer = new System.Windows.Forms.RadioButton();
            this.rdbIzq = new System.Windows.Forms.RadioButton();
            this.alignBox = new System.Windows.Forms.GroupBox();
            this.btnTodo = new System.Windows.Forms.Button();
            this.lista2 = new System.Windows.Forms.CheckedListBox();
            this.btnExtra = new System.Windows.Forms.Button();
            this.btnTodo2 = new System.Windows.Forms.Button();
            this.btnCarga = new System.Windows.Forms.Button();
            this.clickBox.SuspendLayout();
            this.alignBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 2;
            // 
            // nomEquipo
            // 
            this.nomEquipo.AutoSize = true;
            this.nomEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEquipo.Location = new System.Drawing.Point(12, 12);
            this.nomEquipo.Name = "nomEquipo";
            this.nomEquipo.Size = new System.Drawing.Size(229, 20);
            this.nomEquipo.TabIndex = 3;
            this.nomEquipo.Text = "Nombre del equipo a añadir";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(15, 86);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(183, 33);
            this.btnAñadir.TabIndex = 4;
            this.btnAñadir.Text = "Añadir Equipo";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // listaEquipos
            // 
            this.listaEquipos.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEquipos.FormattingEnabled = true;
            this.listaEquipos.Items.AddRange(new object[] {
            "Sevilla",
            "Osasuna",
            "Betis",
            "Madrid",
            "Barcelona"});
            this.listaEquipos.Location = new System.Drawing.Point(15, 134);
            this.listaEquipos.Name = "listaEquipos";
            this.listaEquipos.Size = new System.Drawing.Size(331, 94);
            this.listaEquipos.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(15, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 33);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Seleccion";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInvertir
            // 
            this.btnInvertir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvertir.Location = new System.Drawing.Point(15, 321);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(183, 33);
            this.btnInvertir.TabIndex = 7;
            this.btnInvertir.Text = "Invertir Seleccion";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // chbMulti
            // 
            this.chbMulti.AutoSize = true;
            this.chbMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMulti.Location = new System.Drawing.Point(287, 401);
            this.chbMulti.Name = "chbMulti";
            this.chbMulti.Size = new System.Drawing.Size(126, 24);
            this.chbMulti.TabIndex = 8;
            this.chbMulti.Text = "MultiColumn";
            this.chbMulti.UseVisualStyleBackColor = true;
            this.chbMulti.CheckedChanged += new System.EventHandler(this.chbMulti_CheckedChanged);
            // 
            // chbOrden
            // 
            this.chbOrden.AutoSize = true;
            this.chbOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOrden.Location = new System.Drawing.Point(287, 446);
            this.chbOrden.Name = "chbOrden";
            this.chbOrden.Size = new System.Drawing.Size(163, 24);
            this.chbOrden.TabIndex = 9;
            this.chbOrden.Text = "Orden Alfabetico";
            this.chbOrden.UseVisualStyleBackColor = true;
            this.chbOrden.CheckedChanged += new System.EventHandler(this.chbOrden_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 26);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(82, 23);
            this.rb1.TabIndex = 10;
            this.rb1.Text = "Un Clic";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // clickBox
            // 
            this.clickBox.Controls.Add(this.rb2);
            this.clickBox.Controls.Add(this.rb1);
            this.clickBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickBox.Location = new System.Drawing.Point(15, 376);
            this.clickBox.Name = "clickBox";
            this.clickBox.Size = new System.Drawing.Size(137, 100);
            this.clickBox.TabIndex = 11;
            this.clickBox.TabStop = false;
            this.clickBox.Text = "Clicks";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Checked = true;
            this.rb2.Location = new System.Drawing.Point(6, 71);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(97, 23);
            this.rb2.TabIndex = 11;
            this.rb2.TabStop = true;
            this.rb2.Text = "Dos Clics";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rdbDer
            // 
            this.rdbDer.AutoSize = true;
            this.rdbDer.Location = new System.Drawing.Point(6, 71);
            this.rdbDer.Name = "rdbDer";
            this.rdbDer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbDer.Size = new System.Drawing.Size(92, 23);
            this.rdbDer.TabIndex = 11;
            this.rdbDer.Text = "Derecha";
            this.rdbDer.UseVisualStyleBackColor = true;
            // 
            // rdbIzq
            // 
            this.rdbIzq.AutoSize = true;
            this.rdbIzq.Checked = true;
            this.rdbIzq.Location = new System.Drawing.Point(6, 26);
            this.rdbIzq.Name = "rdbIzq";
            this.rdbIzq.Size = new System.Drawing.Size(101, 23);
            this.rdbIzq.TabIndex = 10;
            this.rdbIzq.TabStop = true;
            this.rdbIzq.Text = "Izquierda";
            this.rdbIzq.UseVisualStyleBackColor = true;
            this.rdbIzq.CheckedChanged += new System.EventHandler(this.rdbIzq_CheckedChanged);
            // 
            // alignBox
            // 
            this.alignBox.Controls.Add(this.rdbDer);
            this.alignBox.Controls.Add(this.rdbIzq);
            this.alignBox.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignBox.Location = new System.Drawing.Point(570, 376);
            this.alignBox.Name = "alignBox";
            this.alignBox.Size = new System.Drawing.Size(137, 100);
            this.alignBox.TabIndex = 12;
            this.alignBox.TabStop = false;
            this.alignBox.Text = "Alinear";
            // 
            // btnTodo
            // 
            this.btnTodo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo.Location = new System.Drawing.Point(15, 243);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(183, 33);
            this.btnTodo.TabIndex = 13;
            this.btnTodo.Text = "Seleccionar Todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // lista2
            // 
            this.lista2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(376, 134);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(331, 94);
            this.lista2.TabIndex = 14;
            // 
            // btnExtra
            // 
            this.btnExtra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtra.Location = new System.Drawing.Point(267, 282);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(183, 33);
            this.btnExtra.TabIndex = 15;
            this.btnExtra.Text = "Extraer Selección";
            this.btnExtra.UseVisualStyleBackColor = true;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click);
            // 
            // btnTodo2
            // 
            this.btnTodo2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodo2.Location = new System.Drawing.Point(524, 243);
            this.btnTodo2.Name = "btnTodo2";
            this.btnTodo2.Size = new System.Drawing.Size(183, 33);
            this.btnTodo2.TabIndex = 16;
            this.btnTodo2.Text = "Seleccionar Todo";
            this.btnTodo2.UseVisualStyleBackColor = true;
            this.btnTodo2.Click += new System.EventHandler(this.btnTodo2_Click);
            // 
            // btnCarga
            // 
            this.btnCarga.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarga.Location = new System.Drawing.Point(408, 46);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(183, 33);
            this.btnCarga.TabIndex = 17;
            this.btnCarga.Text = "Cargar Fichero";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 488);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.btnTodo2);
            this.Controls.Add(this.btnExtra);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.alignBox);
            this.Controls.Add(this.clickBox);
            this.Controls.Add(this.chbOrden);
            this.Controls.Add(this.chbMulti);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listaEquipos);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.nomEquipo);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.clickBox.ResumeLayout(false);
            this.clickBox.PerformLayout();
            this.alignBox.ResumeLayout(false);
            this.alignBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nomEquipo;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.CheckedListBox listaEquipos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.CheckBox chbMulti;
        private System.Windows.Forms.CheckBox chbOrden;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.GroupBox clickBox;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rdbDer;
        private System.Windows.Forms.RadioButton rdbIzq;
        private System.Windows.Forms.GroupBox alignBox;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.CheckedListBox lista2;
        private System.Windows.Forms.Button btnExtra;
        private System.Windows.Forms.Button btnTodo2;
        private System.Windows.Forms.Button btnCarga;
    }
}

