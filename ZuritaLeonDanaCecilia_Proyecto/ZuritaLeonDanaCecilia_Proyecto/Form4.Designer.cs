
namespace ZuritaLeonDanaCecilia_Proyecto
{
    partial class imc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.imagen1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.txtFin2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.label1.Location = new System.Drawing.Point(390, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula tu Indice de Masa Corporal ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.label2.Location = new System.Drawing.Point(257, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(459, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 21.75F);
            this.label4.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.label4.Location = new System.Drawing.Point(204, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(459, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "m";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(337, 227);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(116, 26);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtEstatura
            // 
            this.txtEstatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatura.Location = new System.Drawing.Point(337, 273);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(116, 26);
            this.txtEstatura.TabIndex = 6;
            this.txtEstatura.TextChanged += new System.EventHandler(this.txtEstatura_TextChanged);
            this.txtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstatura_KeyPress);
            // 
            // txtFin
            // 
            this.txtFin.AutoSize = true;
            this.txtFin.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFin.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.txtFin.Location = new System.Drawing.Point(95, 449);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(15, 24);
            this.txtFin.TabIndex = 10;
            this.txtFin.Text = ".";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImage = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.groupBox1.Controls.Add(this.rbMujer);
            this.groupBox1.Controls.Add(this.rbHombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(76, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 108);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.BackColor = System.Drawing.Color.SkyBlue;
            this.rbMujer.Checked = true;
            this.rbMujer.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.rbMujer.Location = new System.Drawing.Point(15, 27);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(58, 22);
            this.rbMujer.TabIndex = 13;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = false;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.BackColor = System.Drawing.Color.SkyBlue;
            this.rbHombre.Font = new System.Drawing.Font("Noto Sans Cond", 9.749999F, System.Drawing.FontStyle.Bold);
            this.rbHombre.Location = new System.Drawing.Point(15, 50);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(70, 22);
            this.rbHombre.TabIndex = 13;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = false;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // imagen1
            // 
            this.imagen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagen1.BackgroundImage")));
            this.imagen1.Location = new System.Drawing.Point(622, 159);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(205, 303);
            this.imagen1.TabIndex = 11;
            this.imagen1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(423, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 39);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(315, 333);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 39);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculo.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalculo.FlatAppearance.BorderSize = 2;
            this.btnCalculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculo.Font = new System.Drawing.Font("Noto Sans", 9.749999F);
            this.btnCalculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculo.Image")));
            this.btnCalculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculo.Location = new System.Drawing.Point(209, 333);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(89, 39);
            this.btnCalculo.TabIndex = 7;
            this.btnCalculo.TabStop = false;
            this.btnCalculo.Text = " Calcular";
            this.btnCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculo.UseVisualStyleBackColor = false;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // txtFin2
            // 
            this.txtFin2.AutoSize = true;
            this.txtFin2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFin2.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.txtFin2.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.txtFin2.Location = new System.Drawing.Point(95, 504);
            this.txtFin2.Name = "txtFin2";
            this.txtFin2.Size = new System.Drawing.Size(15, 24);
            this.txtFin2.TabIndex = 13;
            this.txtFin2.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.bascula;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ZuritaLeonDanaCecilia_Proyecto.Properties.Resources.fondo_imc;
            this.ClientSize = new System.Drawing.Size(1323, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFin2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imagen1);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtEstatura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "imc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calular IMC";
            this.Load += new System.EventHandler(this.imc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label txtFin;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.PictureBox imagen1;
        private System.Windows.Forms.Label txtFin2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}