namespace InterfazUsuario
{
    partial class Login
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
            this.txbUser = new System.Windows.Forms.TextBox();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.gpbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUser
            // 
            this.txbUser.ForeColor = System.Drawing.Color.Gray;
            this.txbUser.Location = new System.Drawing.Point(61, 19);
            this.txbUser.MaxLength = 10;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(122, 20);
            this.txbUser.TabIndex = 1;
            this.txbUser.Text = "Usuario";
            this.txbUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.txbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            this.txbUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.Color.Snow;
            this.gpbLogin.Controls.Add(this.btnAcceder);
            this.gpbLogin.Controls.Add(this.txbPass);
            this.gpbLogin.Controls.Add(this.txbUser);
            this.gpbLogin.Location = new System.Drawing.Point(27, 262);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(246, 185);
            this.gpbLogin.TabIndex = 2;
            this.gpbLogin.TabStop = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(77, 146);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(87, 33);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txbPass
            // 
            this.txbPass.ForeColor = System.Drawing.Color.Gray;
            this.txbPass.Location = new System.Drawing.Point(61, 104);
            this.txbPass.MaxLength = 10;
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(122, 20);
            this.txbPass.TabIndex = 2;
            this.txbPass.Text = "Contraseña";
            this.txbPass.Enter += new System.EventHandler(this.txbPass_Enter);
            this.txbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbKeyPress);
            this.txbPass.Leave += new System.EventHandler(this.txbPass_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazUsuario.Properties.Resources.Sevitaxi;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.DarkRed;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(27, 465);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(246, 33);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 522);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.gpbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRegistro;
    }
}