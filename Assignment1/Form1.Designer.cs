namespace Assignment1
{
    partial class frmA1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmdDb4o = new System.Windows.Forms.Button();
            this.cmdLINQ = new System.Windows.Forms.Button();
            this.cmdInsert = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(166, 38);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 2;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(334, 38);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salary";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(166, 12);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpID.TabIndex = 6;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(334, 8);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 7;
            // 
            // cmdDb4o
            // 
            this.cmdDb4o.Location = new System.Drawing.Point(7, 64);
            this.cmdDb4o.Name = "cmdDb4o";
            this.cmdDb4o.Size = new System.Drawing.Size(59, 50);
            this.cmdDb4o.TabIndex = 9;
            this.cmdDb4o.Text = "Db4o Search";
            this.cmdDb4o.UseVisualStyleBackColor = true;
            this.cmdDb4o.Click += new System.EventHandler(this.cmdDb4o_Click);
            // 
            // cmdLINQ
            // 
            this.cmdLINQ.Location = new System.Drawing.Point(7, 146);
            this.cmdLINQ.Name = "cmdLINQ";
            this.cmdLINQ.Size = new System.Drawing.Size(59, 51);
            this.cmdLINQ.TabIndex = 10;
            this.cmdLINQ.Text = "LINQ Search";
            this.cmdLINQ.UseVisualStyleBackColor = true;
            // 
            // cmdInsert
            // 
            this.cmdInsert.Location = new System.Drawing.Point(454, 7);
            this.cmdInsert.Name = "cmdInsert";
            this.cmdInsert.Size = new System.Drawing.Size(59, 51);
            this.cmdInsert.TabIndex = 11;
            this.cmdInsert.Text = "Insert New Record";
            this.cmdInsert.UseVisualStyleBackColor = true;
            this.cmdInsert.Click += new System.EventHandler(this.cmdInsert_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(7, 231);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(59, 52);
            this.cmdExit.TabIndex = 12;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(78, 64);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(436, 219);
            this.dgvResult.TabIndex = 13;
            // 
            // frmA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 302);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdInsert);
            this.Controls.Add(this.cmdLINQ);
            this.Controls.Add(this.cmdDb4o);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmA1";
            this.Text = "Assignment 1 - Matthew Hall";
            this.Load += new System.EventHandler(this.frmA1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button cmdDb4o;
        private System.Windows.Forms.Button cmdLINQ;
        private System.Windows.Forms.Button cmdInsert;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

