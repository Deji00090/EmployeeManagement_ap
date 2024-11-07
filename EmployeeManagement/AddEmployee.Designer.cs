namespace EmployeeManagement
{
    partial class AddEmployee
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
            employeedata_dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            employee_status = new ComboBox();
            label7 = new Label();
            employeedata_picture = new PictureBox();
            employeedata_gender = new ComboBox();
            employeedata_position = new ComboBox();
            employeedata_number = new TextBox();
            label5 = new Label();
            label6 = new Label();
            employeedata_name = new TextBox();
            employeedata_id = new TextBox();
            employeedata_importbtn = new Button();
            employeedata_clearbtn = new Button();
            employeedata_updatebtn = new Button();
            employeedata_deletebtn = new Button();
            employeedata_addbtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeedata_dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeedata_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(employeedata_dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 298);
            panel1.TabIndex = 0;
            // 
            // employeedata_dataGridView1
            // 
            employeedata_dataGridView1.AllowUserToAddRows = false;
            employeedata_dataGridView1.AllowUserToDeleteRows = false;
            employeedata_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeedata_dataGridView1.Location = new Point(20, 64);
            employeedata_dataGridView1.Name = "employeedata_dataGridView1";
            employeedata_dataGridView1.ReadOnly = true;
            employeedata_dataGridView1.RowHeadersWidth = 62;
            employeedata_dataGridView1.Size = new Size(946, 209);
            employeedata_dataGridView1.TabIndex = 1;
            employeedata_dataGridView1.CellClick += employeedata_dataGridView1_CellClick;
            employeedata_dataGridView1.CellContentClick += employeedata_dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "Employee Data";
            // 
            // panel2
            // 
            panel2.Controls.Add(employee_status);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(employeedata_picture);
            panel2.Controls.Add(employeedata_gender);
            panel2.Controls.Add(employeedata_position);
            panel2.Controls.Add(employeedata_number);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(employeedata_name);
            panel2.Controls.Add(employeedata_id);
            panel2.Controls.Add(employeedata_importbtn);
            panel2.Controls.Add(employeedata_clearbtn);
            panel2.Controls.Add(employeedata_updatebtn);
            panel2.Controls.Add(employeedata_deletebtn);
            panel2.Controls.Add(employeedata_addbtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(35, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 267);
            panel2.TabIndex = 1;
            // 
            // employee_status
            // 
            employee_status.FormattingEnabled = true;
            employee_status.Items.AddRange(new object[] { "Active", "Inactive" });
            employee_status.Location = new Point(556, 133);
            employee_status.Name = "employee_status";
            employee_status.Size = new Size(234, 33);
            employee_status.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(458, 133);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 17;
            label7.Text = "Status:";
            // 
            // employeedata_picture
            // 
            employeedata_picture.Location = new Point(816, 49);
            employeedata_picture.Name = "employeedata_picture";
            employeedata_picture.Size = new Size(150, 144);
            employeedata_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            employeedata_picture.TabIndex = 16;
            employeedata_picture.TabStop = false;
            // 
            // employeedata_gender
            // 
            employeedata_gender.FormattingEnabled = true;
            employeedata_gender.Items.AddRange(new object[] { "Male ", "Female", "Others" });
            employeedata_gender.Location = new Point(155, 133);
            employeedata_gender.Name = "employeedata_gender";
            employeedata_gender.Size = new Size(229, 33);
            employeedata_gender.TabIndex = 15;
            // 
            // employeedata_position
            // 
            employeedata_position.FormattingEnabled = true;
            employeedata_position.Items.AddRange(new object[] { "Software Engineer", "Front End  Engineer", "Back End  Engineer", "Full Stack Engineer" });
            employeedata_position.Location = new Point(556, 90);
            employeedata_position.Name = "employeedata_position";
            employeedata_position.Size = new Size(234, 33);
            employeedata_position.TabIndex = 14;
            // 
            // employeedata_number
            // 
            employeedata_number.Location = new Point(555, 43);
            employeedata_number.Name = "employeedata_number";
            employeedata_number.Size = new Size(235, 31);
            employeedata_number.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 90);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 12;
            label5.Text = "Position:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 50);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 11;
            label6.Text = "Phone Number:";
            // 
            // employeedata_name
            // 
            employeedata_name.Location = new Point(155, 90);
            employeedata_name.Name = "employeedata_name";
            employeedata_name.Size = new Size(230, 31);
            employeedata_name.TabIndex = 9;
            // 
            // employeedata_id
            // 
            employeedata_id.Location = new Point(155, 41);
            employeedata_id.Name = "employeedata_id";
            employeedata_id.Size = new Size(230, 31);
            employeedata_id.TabIndex = 7;
            // 
            // employeedata_importbtn
            // 
            employeedata_importbtn.BackColor = Color.FromArgb(75, 8, 138);
            employeedata_importbtn.FlatStyle = FlatStyle.Popup;
            employeedata_importbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeedata_importbtn.ForeColor = Color.White;
            employeedata_importbtn.Location = new Point(816, 206);
            employeedata_importbtn.Name = "employeedata_importbtn";
            employeedata_importbtn.Size = new Size(150, 41);
            employeedata_importbtn.TabIndex = 6;
            employeedata_importbtn.Text = "Import";
            employeedata_importbtn.UseVisualStyleBackColor = false;
            employeedata_importbtn.Click += employeedata_importbtn_Click;
            // 
            // employeedata_clearbtn
            // 
            employeedata_clearbtn.BackColor = Color.FromArgb(75, 8, 138);
            employeedata_clearbtn.FlatStyle = FlatStyle.Popup;
            employeedata_clearbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeedata_clearbtn.ForeColor = Color.White;
            employeedata_clearbtn.Location = new Point(644, 202);
            employeedata_clearbtn.Name = "employeedata_clearbtn";
            employeedata_clearbtn.Size = new Size(127, 48);
            employeedata_clearbtn.TabIndex = 5;
            employeedata_clearbtn.Text = "Clear";
            employeedata_clearbtn.UseVisualStyleBackColor = false;
            employeedata_clearbtn.Click += employeedata_clearbtn_Click;
            // 
            // employeedata_updatebtn
            // 
            employeedata_updatebtn.BackColor = Color.FromArgb(75, 8, 138);
            employeedata_updatebtn.FlatStyle = FlatStyle.Popup;
            employeedata_updatebtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeedata_updatebtn.ForeColor = Color.White;
            employeedata_updatebtn.Location = new Point(324, 202);
            employeedata_updatebtn.Name = "employeedata_updatebtn";
            employeedata_updatebtn.Size = new Size(127, 48);
            employeedata_updatebtn.TabIndex = 4;
            employeedata_updatebtn.Text = "Update";
            employeedata_updatebtn.UseVisualStyleBackColor = false;
            employeedata_updatebtn.Click += employeedata_updatebtn_Click;
            // 
            // employeedata_deletebtn
            // 
            employeedata_deletebtn.BackColor = Color.FromArgb(75, 8, 138);
            employeedata_deletebtn.FlatStyle = FlatStyle.Popup;
            employeedata_deletebtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeedata_deletebtn.ForeColor = Color.White;
            employeedata_deletebtn.Location = new Point(478, 202);
            employeedata_deletebtn.Name = "employeedata_deletebtn";
            employeedata_deletebtn.Size = new Size(127, 48);
            employeedata_deletebtn.TabIndex = 4;
            employeedata_deletebtn.Text = "Delete";
            employeedata_deletebtn.UseVisualStyleBackColor = false;
            employeedata_deletebtn.Click += employeedata_deletebtn_Click;
            // 
            // employeedata_addbtn
            // 
            employeedata_addbtn.BackColor = Color.FromArgb(75, 8, 138);
            employeedata_addbtn.FlatStyle = FlatStyle.Popup;
            employeedata_addbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeedata_addbtn.ForeColor = Color.White;
            employeedata_addbtn.Location = new Point(172, 202);
            employeedata_addbtn.Name = "employeedata_addbtn";
            employeedata_addbtn.Size = new Size(127, 48);
            employeedata_addbtn.TabIndex = 3;
            employeedata_addbtn.Text = "Add";
            employeedata_addbtn.UseVisualStyleBackColor = false;
            employeedata_addbtn.Click += employeedata_addbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 133);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 2;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 87);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 1;
            label3.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 44);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(1062, 660);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeedata_dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeedata_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView employeedata_dataGridView1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button employeedata_addbtn;
        private Label label4;
        private TextBox employeedata_number;
        private Label label5;
        private Label label6;
        private TextBox employeedata_name;
        private TextBox employeedata_id;
        private Button employeedata_importbtn;
        private Button employeedata_clearbtn;
        private Button employeedata_updatebtn;
        private Button employeedata_deletebtn;
        private ComboBox employeedata_gender;
        private ComboBox employeedata_position;
        private Label label3;
        private PictureBox employeedata_picture;
        private ComboBox employee_status;
        private Label label7;
    }
}
