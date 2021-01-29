
namespace ZuritaLeonDanaCecilia_Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ejercicio = new System.Windows.Forms.Button();
            this.imc = new System.Windows.Forms.Button();
            this.enfermedades = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_prin;
            this.label2.Location = new System.Drawing.Point(70, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Importancia del ejercicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_prin;
            this.label3.Location = new System.Drawing.Point(406, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prevencion de enfermedades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_prin;
            this.label4.Location = new System.Drawing.Point(1042, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Calcula tu IMC";
            // 
            // ejercicio
            // 
            this.ejercicio.BackgroundImage = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.ejercicio;
            this.ejercicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ejercicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ejercicio.FlatAppearance.BorderColor = System.Drawing.Color.MediumOrchid;
            this.ejercicio.FlatAppearance.BorderSize = 2;
            this.ejercicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.ejercicio.Location = new System.Drawing.Point(63, 351);
            this.ejercicio.Name = "ejercicio";
            this.ejercicio.Size = new System.Drawing.Size(252, 160);
            this.ejercicio.TabIndex = 2;
            this.ejercicio.UseVisualStyleBackColor = true;
            this.ejercicio.Click += new System.EventHandler(this.ejercicio_Click);
            // 
            // imc
            // 
            this.imc.BackgroundImage = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.imc;
            this.imc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imc.Location = new System.Drawing.Point(949, 209);
            this.imc.Name = "imc";
            this.imc.Size = new System.Drawing.Size(324, 212);
            this.imc.TabIndex = 4;
            this.imc.UseVisualStyleBackColor = true;
            this.imc.Click += new System.EventHandler(this.imc_Click);
            // 
            // enfermedades
            // 
            this.enfermedades.BackgroundImage = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.enf;
            this.enfermedades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enfermedades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enfermedades.Location = new System.Drawing.Point(411, 126);
            this.enfermedades.Name = "enfermedades";
            this.enfermedades.Size = new System.Drawing.Size(249, 156);
            this.enfermedades.TabIndex = 3;
            this.enfermedades.UseVisualStyleBackColor = true;
            this.enfermedades.Click += new System.EventHandler(this.enfermedades_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.peso;
            this.pictureBox1.Location = new System.Drawing.Point(682, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1323, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ejercicio);
            this.Controls.Add(this.imc);
            this.Controls.Add(this.enfermedades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nutrición";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ejercicio;
        private System.Windows.Forms.Button enfermedades;
        private System.Windows.Forms.Button imc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

