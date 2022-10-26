
namespace EscolapiosInversores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoContraseñaLoginCliente = new System.Windows.Forms.RichTextBox();
            this.campoUsuarioLoginCliente = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonRetrocederLogin = new System.Windows.Forms.Button();
            this.botonAccesoClienteLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESCOLAPInversores - LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "USUARIO:";
            // 
            // campoContraseñaLoginCliente
            // 
            this.campoContraseñaLoginCliente.Location = new System.Drawing.Point(313, 248);
            this.campoContraseñaLoginCliente.Name = "campoContraseñaLoginCliente";
            this.campoContraseñaLoginCliente.Size = new System.Drawing.Size(237, 73);
            this.campoContraseñaLoginCliente.TabIndex = 12;
            this.campoContraseñaLoginCliente.Text = "";
            // 
            // campoUsuarioLoginCliente
            // 
            this.campoUsuarioLoginCliente.Location = new System.Drawing.Point(313, 139);
            this.campoUsuarioLoginCliente.Name = "campoUsuarioLoginCliente";
            this.campoUsuarioLoginCliente.Size = new System.Drawing.Size(237, 73);
            this.campoUsuarioLoginCliente.TabIndex = 11;
            this.campoUsuarioLoginCliente.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 153);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // botonRetrocederLogin
            // 
            this.botonRetrocederLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRetrocederLogin.Location = new System.Drawing.Point(563, 387);
            this.botonRetrocederLogin.Name = "botonRetrocederLogin";
            this.botonRetrocederLogin.Size = new System.Drawing.Size(225, 51);
            this.botonRetrocederLogin.TabIndex = 16;
            this.botonRetrocederLogin.Text = "RETROCEDER";
            this.botonRetrocederLogin.UseVisualStyleBackColor = true;
            // 
            // botonAccesoClienteLogin
            // 
            this.botonAccesoClienteLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAccesoClienteLogin.Location = new System.Drawing.Point(313, 387);
            this.botonAccesoClienteLogin.Name = "botonAccesoClienteLogin";
            this.botonAccesoClienteLogin.Size = new System.Drawing.Size(174, 51);
            this.botonAccesoClienteLogin.TabIndex = 17;
            this.botonAccesoClienteLogin.Text = "ACCEDER";
            this.botonAccesoClienteLogin.UseVisualStyleBackColor = true;
            this.botonAccesoClienteLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 97);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.botonAccesoClienteLogin);
            this.Controls.Add(this.botonRetrocederLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoContraseñaLoginCliente);
            this.Controls.Add(this.campoUsuarioLoginCliente);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "ESCOLAPInversores - LOGIN CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox campoContraseñaLoginCliente;
        private System.Windows.Forms.RichTextBox campoUsuarioLoginCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonRetrocederLogin;
        private System.Windows.Forms.Button botonAccesoClienteLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}