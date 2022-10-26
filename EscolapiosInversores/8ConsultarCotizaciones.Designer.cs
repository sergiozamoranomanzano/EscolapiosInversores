
namespace EscolapiosInversores
{
    partial class ConsultarCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCotizaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoTextoMostrarCotizacionesConsultarCotizaciones = new System.Windows.Forms.RichTextBox();
            this.botonVolverConsultarCotizaciones = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONSULTAR COTIZACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(751, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "SUS COTIZACIONES EN BOLSA SON ACTUALMENTE:";
            // 
            // campoTextoMostrarCotizacionesConsultarCotizaciones
            // 
            this.campoTextoMostrarCotizacionesConsultarCotizaciones.Location = new System.Drawing.Point(19, 119);
            this.campoTextoMostrarCotizacionesConsultarCotizaciones.Name = "campoTextoMostrarCotizacionesConsultarCotizaciones";
            this.campoTextoMostrarCotizacionesConsultarCotizaciones.Size = new System.Drawing.Size(745, 184);
            this.campoTextoMostrarCotizacionesConsultarCotizaciones.TabIndex = 24;
            this.campoTextoMostrarCotizacionesConsultarCotizaciones.Text = "";
            // 
            // botonVolverConsultarCotizaciones
            // 
            this.botonVolverConsultarCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolverConsultarCotizaciones.Location = new System.Drawing.Point(529, 365);
            this.botonVolverConsultarCotizaciones.Name = "botonVolverConsultarCotizaciones";
            this.botonVolverConsultarCotizaciones.Size = new System.Drawing.Size(235, 73);
            this.botonVolverConsultarCotizaciones.TabIndex = 27;
            this.botonVolverConsultarCotizaciones.Text = "VOLVER A OPERACIONES";
            this.botonVolverConsultarCotizaciones.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 97);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // ConsultarCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.botonVolverConsultarCotizaciones);
            this.Controls.Add(this.campoTextoMostrarCotizacionesConsultarCotizaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarCotizaciones";
            this.Text = "ESCOLAPInversiores - CONSULTAR COTIZACIONES";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox campoTextoMostrarCotizacionesConsultarCotizaciones;
        private System.Windows.Forms.Button botonVolverConsultarCotizaciones;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}