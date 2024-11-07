namespace EmployeeManagement
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            signup_loginbtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            signup_showpassword = new CheckBox();
            signup_btn = new Button();
            signup_password = new TextBox();
            signup_username = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // signup_loginbtn
            // 
            signup_loginbtn.BackColor = Color.Navy;
            signup_loginbtn.FlatStyle = FlatStyle.Popup;
            signup_loginbtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_loginbtn.ForeColor = Color.White;
            signup_loginbtn.Location = new Point(27, 461);
            signup_loginbtn.Name = "signup_loginbtn";
            signup_loginbtn.Size = new Size(372, 48);
            signup_loginbtn.TabIndex = 12;
            signup_loginbtn.Text = "SIGN IN";
            signup_loginbtn.UseVisualStyleBackColor = false;
            signup_loginbtn.Click += signup_loginbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(107, 415);
            label2.Name = "label2";
            label2.Size = new Size(202, 28);
            label2.TabIndex = 11;
            label2.Text = "Log In Your Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 190);
            label1.Name = "label1";
            label1.Size = new Size(370, 32);
            label1.TabIndex = 10;
            label1.Text = "Employee Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(signup_loginbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 522);
            panel1.TabIndex = 14;
            // 
            // signup_showpassword
            // 
            signup_showpassword.AutoSize = true;
            signup_showpassword.Location = new Point(635, 302);
            signup_showpassword.Name = "signup_showpassword";
            signup_showpassword.Size = new Size(162, 29);
            signup_showpassword.TabIndex = 21;
            signup_showpassword.Text = "Show Password";
            signup_showpassword.UseVisualStyleBackColor = true;
            signup_showpassword.CheckedChanged += signup_showpassword_CheckedChanged;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.Navy;
            signup_btn.FlatStyle = FlatStyle.Popup;
            signup_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(498, 372);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(130, 48);
            signup_btn.TabIndex = 20;
            signup_btn.Text = "SIGN UP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(504, 250);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(293, 31);
            signup_password.TabIndex = 19;
            // 
            // signup_username
            // 
            signup_username.Location = new Point(504, 162);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(293, 31);
            signup_username.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 206);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 17;
            label5.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 132);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 15;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(498, 70);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 16;
            label4.Text = "Register Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(854, 9);
            label6.Name = "label6";
            label6.Size = new Size(23, 25);
            label6.TabIndex = 22;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 523);
            Controls.Add(label6);
            Controls.Add(signup_showpassword);
            Controls.Add(signup_btn);
            Controls.Add(signup_password);
            Controls.Add(signup_username);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button signup_loginbtn;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private CheckBox signup_showpassword;
        private Button signup_btn;
        private TextBox signup_password;
        private TextBox signup_username;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}