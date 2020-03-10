namespace Las_Ratas
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetiroA = new System.Windows.Forms.Button();
            this.btnDepA = new System.Windows.Forms.Button();
            this.txtDineroAhorro = new System.Windows.Forms.TextBox();
            this.lblSaldoAhorro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRetiroC = new System.Windows.Forms.Button();
            this.btnDepC = new System.Windows.Forms.Button();
            this.txtDineroCorriente = new System.Windows.Forms.TextBox();
            this.lblSaldoCorriente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgvAhorro = new System.Windows.Forms.DataGridView();
            this.xCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvCorriente = new System.Windows.Forms.ListView();
            this.zCuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xMovi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xDine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAhorro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(86, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "CC:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(86, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetiroA);
            this.groupBox2.Controls.Add(this.btnDepA);
            this.groupBox2.Controls.Add(this.txtDineroAhorro);
            this.groupBox2.Controls.Add(this.lblSaldoAhorro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta Ahorros";
            // 
            // btnRetiroA
            // 
            this.btnRetiroA.Location = new System.Drawing.Point(309, 59);
            this.btnRetiroA.Name = "btnRetiroA";
            this.btnRetiroA.Size = new System.Drawing.Size(91, 31);
            this.btnRetiroA.TabIndex = 4;
            this.btnRetiroA.Text = "Retiro";
            this.btnRetiroA.UseVisualStyleBackColor = true;
            this.btnRetiroA.Click += new System.EventHandler(this.btnRetiroA_Click);
            // 
            // btnDepA
            // 
            this.btnDepA.Location = new System.Drawing.Point(208, 59);
            this.btnDepA.Name = "btnDepA";
            this.btnDepA.Size = new System.Drawing.Size(91, 31);
            this.btnDepA.TabIndex = 3;
            this.btnDepA.Text = "Deposito";
            this.btnDepA.UseVisualStyleBackColor = true;
            this.btnDepA.Click += new System.EventHandler(this.btnDepA_Click);
            // 
            // txtDineroAhorro
            // 
            this.txtDineroAhorro.Location = new System.Drawing.Point(10, 62);
            this.txtDineroAhorro.Name = "txtDineroAhorro";
            this.txtDineroAhorro.Size = new System.Drawing.Size(192, 27);
            this.txtDineroAhorro.TabIndex = 2;
            // 
            // lblSaldoAhorro
            // 
            this.lblSaldoAhorro.AutoSize = true;
            this.lblSaldoAhorro.Location = new System.Drawing.Point(107, 23);
            this.lblSaldoAhorro.Name = "lblSaldoAhorro";
            this.lblSaldoAhorro.Size = new System.Drawing.Size(95, 19);
            this.lblSaldoAhorro.TabIndex = 1;
            this.lblSaldoAhorro.Text = "Saldo Ahorro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Saldo Ahorro:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRetiroC);
            this.groupBox3.Controls.Add(this.btnDepC);
            this.groupBox3.Controls.Add(this.txtDineroCorriente);
            this.groupBox3.Controls.Add(this.lblSaldoCorriente);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta Corriente";
            // 
            // btnRetiroC
            // 
            this.btnRetiroC.Location = new System.Drawing.Point(309, 42);
            this.btnRetiroC.Name = "btnRetiroC";
            this.btnRetiroC.Size = new System.Drawing.Size(91, 31);
            this.btnRetiroC.TabIndex = 4;
            this.btnRetiroC.Text = "Retiro";
            this.btnRetiroC.UseVisualStyleBackColor = true;
            this.btnRetiroC.Click += new System.EventHandler(this.btnRetiroC_Click);
            // 
            // btnDepC
            // 
            this.btnDepC.Location = new System.Drawing.Point(208, 42);
            this.btnDepC.Name = "btnDepC";
            this.btnDepC.Size = new System.Drawing.Size(91, 31);
            this.btnDepC.TabIndex = 3;
            this.btnDepC.Text = "Deposito";
            this.btnDepC.UseVisualStyleBackColor = true;
            this.btnDepC.Click += new System.EventHandler(this.btnDepC_Click);
            // 
            // txtDineroCorriente
            // 
            this.txtDineroCorriente.Location = new System.Drawing.Point(10, 45);
            this.txtDineroCorriente.Name = "txtDineroCorriente";
            this.txtDineroCorriente.Size = new System.Drawing.Size(192, 27);
            this.txtDineroCorriente.TabIndex = 2;
            // 
            // lblSaldoCorriente
            // 
            this.lblSaldoCorriente.AutoSize = true;
            this.lblSaldoCorriente.Location = new System.Drawing.Point(124, 23);
            this.lblSaldoCorriente.Name = "lblSaldoCorriente";
            this.lblSaldoCorriente.Size = new System.Drawing.Size(112, 19);
            this.lblSaldoCorriente.TabIndex = 1;
            this.lblSaldoCorriente.Text = "Saldo Corriente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saldo Corriente:";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvanzar.Location = new System.Drawing.Point(652, 85);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(116, 36);
            this.btnAvanzar.TabIndex = 6;
            this.btnAvanzar.Text = "Avanzar mes";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(535, 94);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(41, 19);
            this.lblMes.TabIndex = 8;
            this.lblMes.Text = "Mes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(90, 422);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // dtgvAhorro
            // 
            this.dtgvAhorro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAhorro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAhorro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xCuenta,
            this.xMovimiento,
            this.xDinero});
            this.dtgvAhorro.Location = new System.Drawing.Point(492, 184);
            this.dtgvAhorro.Name = "dtgvAhorro";
            this.dtgvAhorro.Size = new System.Drawing.Size(474, 125);
            this.dtgvAhorro.TabIndex = 11;
            // 
            // xCuenta
            // 
            this.xCuenta.HeaderText = "Cuenta";
            this.xCuenta.Name = "xCuenta";
            // 
            // xMovimiento
            // 
            this.xMovimiento.HeaderText = "Movimiento";
            this.xMovimiento.Name = "xMovimiento";
            // 
            // xDinero
            // 
            this.xDinero.HeaderText = "Dinero";
            this.xDinero.Name = "xDinero";
            // 
            // lvCorriente
            // 
            this.lvCorriente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zCuenta,
            this.xMovi,
            this.xDine});
            this.lvCorriente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCorriente.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCorriente.HideSelection = false;
            this.lvCorriente.Location = new System.Drawing.Point(492, 315);
            this.lvCorriente.Name = "lvCorriente";
            this.lvCorriente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvCorriente.Size = new System.Drawing.Size(474, 126);
            this.lvCorriente.TabIndex = 12;
            this.lvCorriente.UseCompatibleStateImageBehavior = false;
            this.lvCorriente.View = System.Windows.Forms.View.Details;
            // 
            // zCuenta
            // 
            this.zCuenta.Text = "Cuenta";
            this.zCuenta.Width = 130;
            // 
            // xMovi
            // 
            this.xMovi.Text = "Movimiento";
            this.xMovi.Width = 169;
            // 
            // xDine
            // 
            this.xDine.Text = "Dinero";
            this.xDine.Width = 143;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 472);
            this.Controls.Add(this.lvCorriente);
            this.Controls.Add(this.dtgvAhorro);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAhorro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRetiroA;
        private System.Windows.Forms.Button btnDepA;
        private System.Windows.Forms.TextBox txtDineroAhorro;
        private System.Windows.Forms.Label lblSaldoAhorro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRetiroC;
        private System.Windows.Forms.Button btnDepC;
        private System.Windows.Forms.TextBox txtDineroCorriente;
        private System.Windows.Forms.Label lblSaldoCorriente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgvAhorro;
        private System.Windows.Forms.DataGridViewTextBoxColumn xCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDinero;
        private System.Windows.Forms.ListView lvCorriente;
        private System.Windows.Forms.ColumnHeader zCuenta;
        private System.Windows.Forms.ColumnHeader xMovi;
        private System.Windows.Forms.ColumnHeader xDine;
    }
}

