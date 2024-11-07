using MySql.Data.MySqlClient;
using System.Data;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = login_username.Text;
            string pass = login_password.Text;
            string connectionstring = "Server=127.0.0.1; Database=employee; User Id =root; Pwd=Polo$1234;";
            string query = "SELECT  * FROM users WHERE username = @name AND password = @pass";

            //string query = "SELECT * FROM users WHERE username = @name AND password = @pass";
            if (login_username.Text != " " && login_showpassword.Text != "")
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionstring))
                    {
                        con.Open();

                        MySqlCommand com = new MySqlCommand(query, con);
                        com.Parameters.AddWithValue("@name", name);
                        com.Parameters.AddWithValue("@pass", pass);
                        MySqlDataAdapter mySqlDataAdaptor = new MySqlDataAdapter(com);
                        DataTable dt = new DataTable();
                        mySqlDataAdaptor.Fill(dt);
                        com.ExecuteNonQuery();

                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Succesfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mainForm = new();
                            mainForm.Show();
                        }
                        else
                        {

                            MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
