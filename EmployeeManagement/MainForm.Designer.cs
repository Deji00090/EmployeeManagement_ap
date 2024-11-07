namespace EmployeeManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            salary1 = new Salary();
            addEmployee1 = new AddEmployee();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 50);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(297, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(796, 540);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(315, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 8, 138);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(5, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 639);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 566);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(75, 8, 138);
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(32, 340);
            button3.Name = "button3";
            button3.Size = new Size(231, 57);
            button3.TabIndex = 17;
            button3.Text = "SALARY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(75, 8, 138);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(32, 265);
            button2.Name = "button2";
            button2.Size = new Size(231, 57);
            button2.TabIndex = 16;
            button2.Text = "ADD EMPLOYEE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(75, 8, 138);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(32, 185);
            button1.Name = "button1";
            button1.Size = new Size(231, 57);
            button1.TabIndex = 15;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // salary1
            // 
            salary1.Location = new Point(307, 60);
            salary1.Name = "salary1";
            salary1.Size = new Size(1776, 958);
            salary1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(316, 57);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(1593, 990);
            addEmployee1.TabIndex = 3;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(307, 63);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1500, 984);
            dashboard1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 698);
            Controls.Add(dashboard1);
            Controls.Add(addEmployee1);
            Controls.Add(salary1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
    }
}