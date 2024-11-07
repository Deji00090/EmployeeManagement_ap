namespace EmployeeManagement
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel5 = new Panel();
            db3 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            db2 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            db1 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(32, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 199);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(75, 8, 138);
            panel5.Controls.Add(db3);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(611, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 131);
            panel5.TabIndex = 3;
            // 
            // db3
            // 
            db3.AutoSize = true;
            db3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            db3.ForeColor = Color.White;
            db3.Location = new Point(176, 37);
            db3.Name = "db3";
            db3.Size = new Size(33, 38);
            db3.TabIndex = 2;
            db3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(77, 92);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 1;
            label6.Text = "Inactive Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(75, 8, 138);
            panel4.Controls.Add(db2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(316, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 131);
            panel4.TabIndex = 3;
            // 
            // db2
            // 
            db2.AutoSize = true;
            db2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            db2.ForeColor = Color.White;
            db2.Location = new Point(176, 37);
            db2.Name = "db2";
            db2.Size = new Size(33, 38);
            db2.TabIndex = 2;
            db2.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(77, 92);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 1;
            label4.Text = "Active Employee";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(75, 8, 138);
            panel3.Controls.Add(db1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(43, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 131);
            panel3.TabIndex = 0;
            // 
            // db1
            // 
            db1.AutoSize = true;
            db1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            db1.ForeColor = Color.White;
            db1.Location = new Point(176, 37);
            db1.Name = "db1";
            db1.Size = new Size(33, 38);
            db1.TabIndex = 2;
            db1.Text = "0";
            db1.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 92);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 1;
            label1.Text = "Total Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(32, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 348);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(1016, 656);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label db3;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label db2;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label db1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
