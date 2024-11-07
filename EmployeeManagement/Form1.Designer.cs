namespace EmployeeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            login_signupbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            loginbtn = new Button();
            login_showpassword = new CheckBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login_signupbtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 580);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // login_signupbtn
            // 
            login_signupbtn.BackColor = Color.Navy;
            login_signupbtn.FlatStyle = FlatStyle.Popup;
            login_signupbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_signupbtn.ForeColor = Color.White;
            login_signupbtn.Location = new Point(34, 508);
            login_signupbtn.Name = "login_signupbtn";
            login_signupbtn.Size = new Size(399, 48);
            login_signupbtn.TabIndex = 8;
            login_signupbtn.Text = "SIGN UP";
            login_signupbtn.UseVisualStyleBackColor = false;
            login_signupbtn.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(129, 466);
            label2.Name = "label2";
            label2.Size = new Size(222, 28);
            label2.TabIndex = 1;
            label2.Text = "Register Your Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 253);
            label1.Name = "label1";
            label1.Size = new Size(370, 32);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(541, 137);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(541, 75);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 3;
            label4.Text = "Login Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 211);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // login_username
            // 
            login_username.Location = new Point(547, 167);
            login_username.Name = "login_username";
            login_username.Size = new Size(293, 31);
            login_username.TabIndex = 5;
            // 
            // login_password
            // 
            login_password.Location = new Point(547, 255);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(293, 31);
            login_password.TabIndex = 6;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Navy;
            loginbtn.FlatStyle = FlatStyle.Popup;
            loginbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(541, 377);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(130, 48);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            // 
            // login_showpassword
            // 
            login_showpassword.AutoSize = true;
            login_showpassword.Location = new Point(678, 307);
            login_showpassword.Name = "login_showpassword";
            login_showpassword.Size = new Size(162, 29);
            login_showpassword.TabIndex = 8;
            login_showpassword.Text = "Show Password";
            login_showpassword.UseVisualStyleBackColor = true;
            login_showpassword.CheckedChanged += login_showpassword_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(853, 16);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 9;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 579);
            Controls.Add(label6);
            Controls.Add(login_showpassword);
            Controls.Add(loginbtn);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button login_signupbtn;
        private TextBox login_username;
        private TextBox login_password;
        private Button loginbtn;
        private CheckBox login_showpassword;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
