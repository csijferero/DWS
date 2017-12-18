namespace InterfazUsuario
{
    partial class RegistroUsuario
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
            this.txbNewUser = new System.Windows.Forms.TextBox();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.chdTerminos = new System.Windows.Forms.CheckBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txbConfirmNewPass = new System.Windows.Forms.TextBox();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNewUser
            // 
            this.txbNewUser.ForeColor = System.Drawing.Color.Gray;
            this.txbNewUser.Location = new System.Drawing.Point(62, 19);
            this.txbNewUser.MaxLength = 10;
            this.txbNewUser.Name = "txbNewUser";
            this.txbNewUser.Size = new System.Drawing.Size(122, 20);
            this.txbNewUser.TabIndex = 1;
            this.txbNewUser.Text = "Usuario";
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbLogin.Controls.Add(this.chdTerminos);
            this.gpbLogin.Controls.Add(this.btnRegistro);
            this.gpbLogin.Controls.Add(this.txbConfirmNewPass);
            this.gpbLogin.Controls.Add(this.txbNewPass);
            this.gpbLogin.Controls.Add(this.txbNewUser);
            this.gpbLogin.Location = new System.Drawing.Point(27, 262);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(246, 291);
            this.gpbLogin.TabIndex = 6;
            this.gpbLogin.TabStop = false;
            // 
            // chdTerminos
            // 
            this.chdTerminos.AutoSize = true;
            this.chdTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chdTerminos.Location = new System.Drawing.Point(16, 194);
            this.chdTerminos.Name = "chdTerminos";
            this.chdTerminos.Size = new System.Drawing.Size(224, 17);
            this.chdTerminos.TabIndex = 7;
            this.chdTerminos.Text = "Acepto los Terminos y Condiciones";
            this.chdTerminos.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.Blue;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(72, 227);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(103, 33);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txbConfirmNewPass
            // 
            this.txbConfirmNewPass.ForeColor = System.Drawing.Color.Gray;
            this.txbConfirmNewPass.Location = new System.Drawing.Point(62, 154);
            this.txbConfirmNewPass.MaxLength = 10;
            this.txbConfirmNewPass.Name = "txbConfirmNewPass";
            this.txbConfirmNewPass.Size = new System.Drawing.Size(122, 20);
            this.txbConfirmNewPass.TabIndex = 3;
            this.txbConfirmNewPass.Text = "Confirmar Contraseña";
            // 
            // txbNewPass
            // 
            this.txbNewPass.ForeColor = System.Drawing.Color.Gray;
            this.txbNewPass.Location = new System.Drawing.Point(62, 86);
            this.txbNewPass.MaxLength = 10;
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(122, 20);
            this.txbNewPass.TabIndex = 2;
            this.txbNewPass.Text = "Contraseña";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyWin_Fernandez_JoseAntonio.Properties.Resources.Sevitaxi;
            this.pictureBox2.Location = new System.Drawing.Point(27, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 218);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 565);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.pictureBox2);
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbNewUser;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chdTerminos;
        private System.Windows.Forms.TextBox txbConfirmNewPass;
    }
}