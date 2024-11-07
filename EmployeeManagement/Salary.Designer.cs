namespace EmployeeManagement
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            salaryUpdate_btn = new Button();
            salary_employee = new TextBox();
            label5 = new Label();
            salaryemployeeposition = new TextBox();
            label4 = new Label();
            salaryemployeename = new TextBox();
            label3 = new Label();
            salaryemployeeid = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(salaryUpdate_btn);
            panel1.Controls.Add(salary_employee);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salaryemployeeposition);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(salaryemployeename);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salaryemployeeid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 578);
            panel1.TabIndex = 0;
            // 
            // salaryUpdate_btn
            // 
            salaryUpdate_btn.BackColor = Color.FromArgb(75, 8, 138);
            salaryUpdate_btn.FlatStyle = FlatStyle.Popup;
            salaryUpdate_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salaryUpdate_btn.ForeColor = Color.White;
            salaryUpdate_btn.Location = new Point(28, 422);
            salaryUpdate_btn.Name = "salaryUpdate_btn";
            salaryUpdate_btn.Size = new Size(111, 48);
            salaryUpdate_btn.TabIndex = 8;
            salaryUpdate_btn.Text = "Update";
            salaryUpdate_btn.UseVisualStyleBackColor = false;
            salaryUpdate_btn.Click += salaryUpdate_btn_Click;
            // 
            // salary_employee
            // 
            salary_employee.Location = new Point(28, 359);
            salary_employee.Multiline = true;
            salary_employee.Name = "salary_employee";
            salary_employee.Size = new Size(292, 31);
            salary_employee.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 317);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 6;
            label5.Text = "Salary";
            // 
            // salaryemployeeposition
            // 
            salaryemployeeposition.Location = new Point(28, 260);
            salaryemployeeposition.Multiline = true;
            salaryemployeeposition.Name = "salaryemployeeposition";
            salaryemployeeposition.Size = new Size(292, 31);
            salaryemployeeposition.TabIndex = 5;
            salaryemployeeposition.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 219);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 4;
            label4.Text = "Position";
            // 
            // salaryemployeename
            // 
            salaryemployeename.Location = new Point(28, 163);
            salaryemployeename.Multiline = true;
            salaryemployeename.Name = "salaryemployeename";
            salaryemployeename.Size = new Size(292, 31);
            salaryemployeename.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 122);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Full name";
            // 
            // salaryemployeeid
            // 
            salaryemployeeid.Location = new Point(28, 77);
            salaryemployeeid.Multiline = true;
            salaryemployeeid.Name = "salaryemployeeid";
            salaryemployeeid.Size = new Size(292, 38);
            salaryemployeeid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 28);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 0;
            label2.Text = "Employee Id";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(430, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(726, 578);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(647, 473);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 38);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(1184, 639);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox salary_employee;
        private Label label5;
        private TextBox salaryemployeeposition;
        private Label label4;
        private TextBox salaryemployeename;
        private Label label3;
        private TextBox salaryemployeeid;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button salaryUpdate_btn;
    }
}
