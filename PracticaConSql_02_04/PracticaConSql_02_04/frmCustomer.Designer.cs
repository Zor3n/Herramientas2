namespace PracticaConSql_02_04
{
    partial class frmCustomer
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
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.txtHood = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvCustomerList = new System.Windows.Forms.ListView();
            this.cohID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohSur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cohHood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGenResult = new System.Windows.Forms.Label();
            this.lblBornResult = new System.Windows.Forms.Label();
            this.lblHoodResult = new System.Windows.Forms.Label();
            this.lblSurResult = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.cbIdCustomer = new System.Windows.Forms.ComboBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.gbAddCustomer.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.Controls.Add(this.gbGender);
            this.gbAddCustomer.Controls.Add(this.btnAddCustomer);
            this.gbAddCustomer.Controls.Add(this.dtpBornDate);
            this.gbAddCustomer.Controls.Add(this.txtHood);
            this.gbAddCustomer.Controls.Add(this.txtSurname);
            this.gbAddCustomer.Controls.Add(this.txtName);
            this.gbAddCustomer.Controls.Add(this.txtID);
            this.gbAddCustomer.Controls.Add(this.label5);
            this.gbAddCustomer.Controls.Add(this.label4);
            this.gbAddCustomer.Controls.Add(this.label3);
            this.gbAddCustomer.Controls.Add(this.label2);
            this.gbAddCustomer.Controls.Add(this.label1);
            this.gbAddCustomer.Location = new System.Drawing.Point(12, 3);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(563, 231);
            this.gbAddCustomer.TabIndex = 0;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add Customer";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbnMale);
            this.gbGender.Controls.Add(this.rbnFemale);
            this.gbGender.Location = new System.Drawing.Point(345, 40);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(114, 100);
            this.gbGender.TabIndex = 12;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(6, 55);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(60, 23);
            this.rbnMale.TabIndex = 14;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Checked = true;
            this.rbnFemale.Location = new System.Drawing.Point(6, 26);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(74, 23);
            this.rbnFemale.TabIndex = 13;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Location = new System.Drawing.Point(395, 179);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(88, 36);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBornDate.Location = new System.Drawing.Point(116, 182);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(115, 27);
            this.dtpBornDate.TabIndex = 10;
            // 
            // txtHood
            // 
            this.txtHood.Location = new System.Drawing.Point(116, 149);
            this.txtHood.Name = "txtHood";
            this.txtHood.Size = new System.Drawing.Size(179, 27);
            this.txtHood.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(116, 109);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(179, 27);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 27);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(179, 27);
            this.txtID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Born Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Neighborhood:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // lvCustomerList
            // 
            this.lvCustomerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cohID,
            this.cohName,
            this.cohSur,
            this.cohBornDate,
            this.cohGender,
            this.cohHood});
            this.lvCustomerList.Enabled = false;
            this.lvCustomerList.GridLines = true;
            this.lvCustomerList.HideSelection = false;
            this.lvCustomerList.Location = new System.Drawing.Point(12, 249);
            this.lvCustomerList.Name = "lvCustomerList";
            this.lvCustomerList.Size = new System.Drawing.Size(563, 258);
            this.lvCustomerList.TabIndex = 1;
            this.lvCustomerList.UseCompatibleStateImageBehavior = false;
            this.lvCustomerList.View = System.Windows.Forms.View.Details;
            // 
            // cohID
            // 
            this.cohID.Text = "ID";
            this.cohID.Width = 93;
            // 
            // cohName
            // 
            this.cohName.Text = "Name";
            this.cohName.Width = 93;
            // 
            // cohSur
            // 
            this.cohSur.Text = "Surname";
            this.cohSur.Width = 93;
            // 
            // cohBornDate
            // 
            this.cohBornDate.Text = "Born Date";
            this.cohBornDate.Width = 93;
            // 
            // cohGender
            // 
            this.cohGender.Text = "Gender";
            this.cohGender.Width = 93;
            // 
            // cohHood
            // 
            this.cohHood.Text = "Hood";
            this.cohHood.Width = 93;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.btnDeleteCustomer);
            this.gbCustomer.Controls.Add(this.cbIdCustomer);
            this.gbCustomer.Controls.Add(this.lblGenResult);
            this.gbCustomer.Controls.Add(this.lblBornResult);
            this.gbCustomer.Controls.Add(this.lblHoodResult);
            this.gbCustomer.Controls.Add(this.lblSurResult);
            this.gbCustomer.Controls.Add(this.lblNameResult);
            this.gbCustomer.Controls.Add(this.label11);
            this.gbCustomer.Controls.Add(this.label10);
            this.gbCustomer.Controls.Add(this.label9);
            this.gbCustomer.Controls.Add(this.label8);
            this.gbCustomer.Controls.Add(this.label7);
            this.gbCustomer.Controls.Add(this.label6);
            this.gbCustomer.Location = new System.Drawing.Point(581, 3);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(469, 231);
            this.gbCustomer.TabIndex = 2;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Find Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Surame:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Hood:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Born Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Gender:";
            // 
            // lblGenResult
            // 
            this.lblGenResult.AutoSize = true;
            this.lblGenResult.Location = new System.Drawing.Point(90, 195);
            this.lblGenResult.Name = "lblGenResult";
            this.lblGenResult.Size = new System.Drawing.Size(0, 19);
            this.lblGenResult.TabIndex = 13;
            // 
            // lblBornResult
            // 
            this.lblBornResult.AutoSize = true;
            this.lblBornResult.Location = new System.Drawing.Point(90, 165);
            this.lblBornResult.Name = "lblBornResult";
            this.lblBornResult.Size = new System.Drawing.Size(0, 19);
            this.lblBornResult.TabIndex = 12;
            // 
            // lblHoodResult
            // 
            this.lblHoodResult.AutoSize = true;
            this.lblHoodResult.Location = new System.Drawing.Point(90, 135);
            this.lblHoodResult.Name = "lblHoodResult";
            this.lblHoodResult.Size = new System.Drawing.Size(0, 19);
            this.lblHoodResult.TabIndex = 11;
            // 
            // lblSurResult
            // 
            this.lblSurResult.AutoSize = true;
            this.lblSurResult.Location = new System.Drawing.Point(90, 107);
            this.lblSurResult.Name = "lblSurResult";
            this.lblSurResult.Size = new System.Drawing.Size(0, 19);
            this.lblSurResult.TabIndex = 10;
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Location = new System.Drawing.Point(90, 81);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(0, 19);
            this.lblNameResult.TabIndex = 9;
            // 
            // cbIdCustomer
            // 
            this.cbIdCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIdCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdCustomer.FormattingEnabled = true;
            this.cbIdCustomer.Location = new System.Drawing.Point(39, 20);
            this.cbIdCustomer.Name = "cbIdCustomer";
            this.cbIdCustomer.Size = new System.Drawing.Size(177, 27);
            this.cbIdCustomer.TabIndex = 3;
            this.cbIdCustomer.SelectedIndexChanged += new System.EventHandler(this.cbIdCustomer_SelectedIndexChanged);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(287, 14);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(88, 36);
            this.btnDeleteCustomer.TabIndex = 13;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 509);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.lvCustomerList);
            this.Controls.Add(this.gbAddCustomer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(903, 548);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.TextBox txtHood;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.ListView lvCustomerList;
        private System.Windows.Forms.ColumnHeader cohID;
        private System.Windows.Forms.ColumnHeader cohName;
        private System.Windows.Forms.ColumnHeader cohSur;
        private System.Windows.Forms.ColumnHeader cohBornDate;
        private System.Windows.Forms.ColumnHeader cohGender;
        private System.Windows.Forms.ColumnHeader cohHood;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGenResult;
        private System.Windows.Forms.Label lblBornResult;
        private System.Windows.Forms.Label lblHoodResult;
        private System.Windows.Forms.Label lblSurResult;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}

