namespace APIEmployeeInfo.App.Views
{
    partial class EmployeeViews
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.rbFMale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.pnlEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.btnDel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.btnNew);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.pnlEntry);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(908, 480);
            this.pnlMain.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(436, 445);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(328, 445);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 28);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Remove";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 445);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(112, 445);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 445);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 28);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 218);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 216);
            this.panel2.TabIndex = 3;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.empFName,
            this.empMName,
            this.empLName,
            this.empAdd,
            this.empAge,
            this.empGender});
            this.dgvMain.DataSource = this.bsMain;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(908, 216);
            this.dgvMain.TabIndex = 0;
            // 
            // empID
            // 
            this.empID.DataPropertyName = "empID";
            this.empID.HeaderText = "Employee ID";
            this.empID.MinimumWidth = 6;
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            // 
            // empFName
            // 
            this.empFName.DataPropertyName = "empFName";
            this.empFName.HeaderText = "FirstName";
            this.empFName.MinimumWidth = 6;
            this.empFName.Name = "empFName";
            this.empFName.ReadOnly = true;
            // 
            // empMName
            // 
            this.empMName.DataPropertyName = "empMName";
            this.empMName.HeaderText = "Middle Name";
            this.empMName.MinimumWidth = 6;
            this.empMName.Name = "empMName";
            this.empMName.ReadOnly = true;
            // 
            // empLName
            // 
            this.empLName.DataPropertyName = "empLName";
            this.empLName.HeaderText = "Last Name";
            this.empLName.MinimumWidth = 6;
            this.empLName.Name = "empLName";
            this.empLName.ReadOnly = true;
            // 
            // empAdd
            // 
            this.empAdd.DataPropertyName = "empAdd";
            this.empAdd.HeaderText = "Address";
            this.empAdd.MinimumWidth = 6;
            this.empAdd.Name = "empAdd";
            this.empAdd.ReadOnly = true;
            // 
            // empAge
            // 
            this.empAge.DataPropertyName = "empAge";
            this.empAge.HeaderText = "Age";
            this.empAge.MinimumWidth = 6;
            this.empAge.Name = "empAge";
            this.empAge.ReadOnly = true;
            // 
            // empGender
            // 
            this.empGender.DataPropertyName = "empGender";
            this.empGender.HeaderText = "Gender";
            this.empGender.MinimumWidth = 6;
            this.empGender.Name = "empGender";
            this.empGender.ReadOnly = true;
            // 
            // pnlEntry
            // 
            this.pnlEntry.Controls.Add(this.label8);
            this.pnlEntry.Controls.Add(this.rbFMale);
            this.pnlEntry.Controls.Add(this.rbMale);
            this.pnlEntry.Controls.Add(this.txtEmpID);
            this.pnlEntry.Controls.Add(this.txtAge);
            this.pnlEntry.Controls.Add(this.label5);
            this.pnlEntry.Controls.Add(this.txtAddress);
            this.pnlEntry.Controls.Add(this.label4);
            this.pnlEntry.Controls.Add(this.label1);
            this.pnlEntry.Controls.Add(this.label3);
            this.pnlEntry.Controls.Add(this.label7);
            this.pnlEntry.Controls.Add(this.label6);
            this.pnlEntry.Controls.Add(this.label2);
            this.pnlEntry.Controls.Add(this.txtLName);
            this.pnlEntry.Controls.Add(this.txtMName);
            this.pnlEntry.Controls.Add(this.txtEmpName);
            this.pnlEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntry.Location = new System.Drawing.Point(0, 0);
            this.pnlEntry.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(908, 218);
            this.pnlEntry.TabIndex = 2;
            // 
            // rbFMale
            // 
            this.rbFMale.AutoSize = true;
            this.rbFMale.Location = new System.Drawing.Point(679, 103);
            this.rbFMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFMale.Name = "rbFMale";
            this.rbFMale.Size = new System.Drawing.Size(74, 20);
            this.rbFMale.TabIndex = 7;
            this.rbFMale.TabStop = true;
            this.rbFMale.Text = "Female";
            this.rbFMale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(607, 103);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(161, 34);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(175, 22);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.TabStop = false;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(607, 64);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(51, 22);
            this.txtAge.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(464, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(607, 32);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(283, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(464, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(464, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Last Name:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Middle Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(161, 130);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(137, 22);
            this.txtLName.TabIndex = 3;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(161, 98);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(137, 22);
            this.txtMName.TabIndex = 2;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(161, 66);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(283, 22);
            this.txtEmpName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Employee List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 480);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeViews";
            this.Text = "Employee";
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.RadioButton rbFMale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn empGender;
        private System.Windows.Forms.Label label8;
    }
}