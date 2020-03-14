namespace Practica_14_03_2020
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.btnDepositoAhorro = new System.Windows.Forms.Button();
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroID = new System.Windows.Forms.Label();
            this.grbBanco = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldoAhorro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaldoCorriente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.btnRetiroAhorro = new System.Windows.Forms.Button();
            this.btnRetiroCorriente = new System.Windows.Forms.Button();
            this.btnDepostioCorriente = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAvanzarMes = new System.Windows.Forms.Button();
            this.grbDetalles.SuspendLayout();
            this.grbBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.lblSaldoTotal);
            this.grbDetalles.Controls.Add(this.label4);
            this.grbDetalles.Controls.Add(this.label1);
            this.grbDetalles.Controls.Add(this.lblNumeroID);
            this.grbDetalles.Controls.Add(this.lblNombreCuenta);
            this.grbDetalles.Controls.Add(this.label3);
            this.grbDetalles.Location = new System.Drawing.Point(12, 12);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(423, 127);
            this.grbDetalles.TabIndex = 1;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles";
            // 
            // btnDepositoAhorro
            // 
            this.btnDepositoAhorro.Location = new System.Drawing.Point(287, 23);
            this.btnDepositoAhorro.Name = "btnDepositoAhorro";
            this.btnDepositoAhorro.Size = new System.Drawing.Size(88, 28);
            this.btnDepositoAhorro.TabIndex = 3;
            this.btnDepositoAhorro.Text = "Deposito";
            this.btnDepositoAhorro.UseVisualStyleBackColor = true;
            this.btnDepositoAhorro.Click += new System.EventHandler(this.btnDepositoAhorro_Click);
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Location = new System.Drawing.Point(94, 23);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(49, 19);
            this.lblNombreCuenta.TabIndex = 4;
            this.lblNombreCuenta.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // lblNumeroID
            // 
            this.lblNumeroID.AutoSize = true;
            this.lblNumeroID.Location = new System.Drawing.Point(94, 51);
            this.lblNumeroID.Name = "lblNumeroID";
            this.lblNumeroID.Size = new System.Drawing.Size(49, 19);
            this.lblNumeroID.TabIndex = 6;
            this.lblNumeroID.Text = "label4";
            // 
            // grbBanco
            // 
            this.grbBanco.Controls.Add(this.btnAvanzarMes);
            this.grbBanco.Controls.Add(this.lblMes);
            this.grbBanco.Controls.Add(this.label7);
            this.grbBanco.Controls.Add(this.btnRetiroCorriente);
            this.grbBanco.Controls.Add(this.btnDepostioCorriente);
            this.grbBanco.Controls.Add(this.btnRetiroAhorro);
            this.grbBanco.Controls.Add(this.lblSaldoCorriente);
            this.grbBanco.Controls.Add(this.label5);
            this.grbBanco.Controls.Add(this.btnDepositoAhorro);
            this.grbBanco.Controls.Add(this.lblSaldoAhorro);
            this.grbBanco.Controls.Add(this.label2);
            this.grbBanco.Location = new System.Drawing.Point(12, 155);
            this.grbBanco.Name = "grbBanco";
            this.grbBanco.Size = new System.Drawing.Size(423, 301);
            this.grbBanco.TabIndex = 2;
            this.grbBanco.TabStop = false;
            this.grbBanco.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cuenta de ahorros:";
            // 
            // lblSaldoAhorro
            // 
            this.lblSaldoAhorro.AutoSize = true;
            this.lblSaldoAhorro.Location = new System.Drawing.Point(144, 23);
            this.lblSaldoAhorro.Name = "lblSaldoAhorro";
            this.lblSaldoAhorro.Size = new System.Drawing.Size(53, 19);
            this.lblSaldoAhorro.TabIndex = 8;
            this.lblSaldoAhorro.Text = "SaldoA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuenta corriente:";
            // 
            // lblSaldoCorriente
            // 
            this.lblSaldoCorriente.AutoSize = true;
            this.lblSaldoCorriente.Location = new System.Drawing.Point(144, 132);
            this.lblSaldoCorriente.Name = "lblSaldoCorriente";
            this.lblSaldoCorriente.Size = new System.Drawing.Size(53, 19);
            this.lblSaldoCorriente.TabIndex = 10;
            this.lblSaldoCorriente.Text = "SaldoC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saldo total:";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Location = new System.Drawing.Point(94, 87);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(52, 19);
            this.lblSaldoTotal.TabIndex = 12;
            this.lblSaldoTotal.Text = "SaldoT";
            // 
            // btnRetiroAhorro
            // 
            this.btnRetiroAhorro.Location = new System.Drawing.Point(287, 57);
            this.btnRetiroAhorro.Name = "btnRetiroAhorro";
            this.btnRetiroAhorro.Size = new System.Drawing.Size(88, 28);
            this.btnRetiroAhorro.TabIndex = 4;
            this.btnRetiroAhorro.Text = "Retiro";
            this.btnRetiroAhorro.UseVisualStyleBackColor = true;
            this.btnRetiroAhorro.Click += new System.EventHandler(this.btnRetiroAhorro_Click);
            // 
            // btnRetiroCorriente
            // 
            this.btnRetiroCorriente.Location = new System.Drawing.Point(287, 166);
            this.btnRetiroCorriente.Name = "btnRetiroCorriente";
            this.btnRetiroCorriente.Size = new System.Drawing.Size(88, 28);
            this.btnRetiroCorriente.TabIndex = 12;
            this.btnRetiroCorriente.Text = "Retiro";
            this.btnRetiroCorriente.UseVisualStyleBackColor = true;
            this.btnRetiroCorriente.Click += new System.EventHandler(this.btnRetiroCorriente_Click);
            // 
            // btnDepostioCorriente
            // 
            this.btnDepostioCorriente.Location = new System.Drawing.Point(287, 132);
            this.btnDepostioCorriente.Name = "btnDepostioCorriente";
            this.btnDepostioCorriente.Size = new System.Drawing.Size(88, 28);
            this.btnDepostioCorriente.TabIndex = 11;
            this.btnDepostioCorriente.Text = "Deposito";
            this.btnDepostioCorriente.UseVisualStyleBackColor = true;
            this.btnDepostioCorriente.Click += new System.EventHandler(this.btnDepostioCorriente_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(53, 239);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(47, 19);
            this.lblMes.TabIndex = 14;
            this.lblMes.Text = "NMes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mes:";
            // 
            // btnAvanzarMes
            // 
            this.btnAvanzarMes.Location = new System.Drawing.Point(213, 230);
            this.btnAvanzarMes.Name = "btnAvanzarMes";
            this.btnAvanzarMes.Size = new System.Drawing.Size(162, 28);
            this.btnAvanzarMes.TabIndex = 15;
            this.btnAvanzarMes.Text = "Mes siguiente";
            this.btnAvanzarMes.UseVisualStyleBackColor = true;
            this.btnAvanzarMes.Click += new System.EventHandler(this.btnAvanzarMes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 468);
            this.Controls.Add(this.grbBanco);
            this.Controls.Add(this.grbDetalles);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.grbDetalles.ResumeLayout(false);
            this.grbDetalles.PerformLayout();
            this.grbBanco.ResumeLayout(false);
            this.grbBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDetalles;
        private System.Windows.Forms.Label lblNumeroID;
        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDepositoAhorro;
        private System.Windows.Forms.GroupBox grbBanco;
        private System.Windows.Forms.Label lblSaldoCorriente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaldoAhorro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRetiroAhorro;
        private System.Windows.Forms.Button btnRetiroCorriente;
        private System.Windows.Forms.Button btnDepostioCorriente;
        private System.Windows.Forms.Button btnAvanzarMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label7;
    }
}

