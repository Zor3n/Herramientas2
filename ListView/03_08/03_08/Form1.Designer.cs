namespace _03_08
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lvAlimentos = new System.Windows.Forms.ListView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblElemento = new System.Windows.Forms.Label();
            this.grbxAgregar = new System.Windows.Forms.GroupBox();
            this.rbtnCarnes = new System.Windows.Forms.RadioButton();
            this.rbtnFrutas = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbxAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_03_08.Properties.Resources.Duck;
            this.pictureBox1.Location = new System.Drawing.Point(540, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(540, 207);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 35);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvAlimentos
            // 
            this.lvAlimentos.HideSelection = false;
            this.lvAlimentos.Location = new System.Drawing.Point(12, 12);
            this.lvAlimentos.Name = "lvAlimentos";
            this.lvAlimentos.Size = new System.Drawing.Size(499, 189);
            this.lvAlimentos.TabIndex = 4;
            this.lvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.lvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAlimentos_MouseClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(12, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 35);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(128, 215);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(49, 19);
            this.lblElemento.TabIndex = 6;
            this.lblElemento.Text = "label1";
            // 
            // grbxAgregar
            // 
            this.grbxAgregar.Controls.Add(this.rbtnCarnes);
            this.grbxAgregar.Controls.Add(this.rbtnFrutas);
            this.grbxAgregar.Controls.Add(this.btnAgregar);
            this.grbxAgregar.Controls.Add(this.txtElemento);
            this.grbxAgregar.Location = new System.Drawing.Point(12, 265);
            this.grbxAgregar.Name = "grbxAgregar";
            this.grbxAgregar.Size = new System.Drawing.Size(499, 97);
            this.grbxAgregar.TabIndex = 7;
            this.grbxAgregar.TabStop = false;
            this.grbxAgregar.Text = "Agregar";
            // 
            // rbtnCarnes
            // 
            this.rbtnCarnes.AutoSize = true;
            this.rbtnCarnes.Location = new System.Drawing.Point(261, 52);
            this.rbtnCarnes.Name = "rbtnCarnes";
            this.rbtnCarnes.Size = new System.Drawing.Size(72, 23);
            this.rbtnCarnes.TabIndex = 9;
            this.rbtnCarnes.Text = "Carnes";
            this.rbtnCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtnFrutas
            // 
            this.rbtnFrutas.AutoSize = true;
            this.rbtnFrutas.Checked = true;
            this.rbtnFrutas.Location = new System.Drawing.Point(261, 23);
            this.rbtnFrutas.Name = "rbtnFrutas";
            this.rbtnFrutas.Size = new System.Drawing.Size(67, 23);
            this.rbtnFrutas.TabIndex = 8;
            this.rbtnFrutas.TabStop = true;
            this.rbtnFrutas.Text = "Frutas";
            this.rbtnFrutas.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 35);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(3, 23);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(218, 27);
            this.txtElemento.TabIndex = 0;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(388, 218);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(49, 19);
            this.lblIndice.TabIndex = 8;
            this.lblIndice.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.grbxAgregar);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lvAlimentos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbxAgregar.ResumeLayout(false);
            this.grbxAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListView lvAlimentos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.GroupBox grbxAgregar;
        private System.Windows.Forms.RadioButton rbtnCarnes;
        private System.Windows.Forms.RadioButton rbtnFrutas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblIndice;
    }
}

