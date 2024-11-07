namespace EmployeeManagement
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out", "Confiramtion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                Application.Exit();
            }
        }
    }
}
