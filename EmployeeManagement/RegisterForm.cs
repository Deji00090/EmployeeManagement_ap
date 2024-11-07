using MySql.Data.MySqlClient;


namespace EmployeeManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showpassword.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            string username = signup_username.Text;
            string password = signup_password.Text;
            DateTime date = DateTime.Now;

            //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

            //string connectionstring = "Server= localhost; Database = library; Uid = root; Pwd = Polo$1234;";
            string connectionstring = "Server=127.0.0.1; Database=employee; User Id =root; Pwd=Polo$1234;";

            if (signup_username.Text != " " && signup_password.Text != "")
            {
                MySqlConnection mySqlConnection = new MySqlConnection(connectionstring);
                try
                {
                    //username,password,date_register
                    mySqlConnection.Open();
                    string query = "INSERT INTO users (username, password,date_register)" +
                           " VALUES(@username,@password,@date)";
                    MySqlCommand com = new MySqlCommand(query, mySqlConnection);
                    com.Parameters.AddWithValue("@username", username);
                    com.Parameters.AddWithValue("@password", password);
                    com.Parameters.AddWithValue("@date", date);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Registered Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form = new Form1();
                    form.Show();
                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Insert data to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Fill in empty field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
