using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace EmployeeManagement
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            display1();
            display2();
            display3();

        }

        static string connectionstring = "Server=127.0.0.1; Database=employee; User Id =root; Pwd=Polo$1234;";
        MySqlConnection con = new MySqlConnection(connectionstring);
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        public void display1()
        {

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(id) FROM employees where insert_date is not null";
                    using (MySqlCommand com = new MySqlCommand(query, con))
                    {
                        MySqlDataReader mySqlDataReader = com.ExecuteReader();

                        if (mySqlDataReader.Read())
                        {
                            int count = Convert.ToInt32(mySqlDataReader[0]);
                            db1.Text = count.ToString();
                        }
                        mySqlDataReader.Close();
                    }

                    
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                finally
                {
                    con.Close();
                }
            }

        }

        public void display2()
        {

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    
                    con.Open();
                   
                    string query = "SELECT COUNT(id) FROM employees WHERE status = @aistatus  AND delete_date IS NULL ";
                    using (MySqlCommand com = new MySqlCommand(query, con))
                    {
                        com.Parameters.AddWithValue("@aistatus", "Active");
                        MySqlDataReader mySqlDataReader = com.ExecuteReader();
                        

                        if (mySqlDataReader.Read())
                        {
                            int count = Convert.ToInt32(mySqlDataReader[0]);
                            db2.Text = count.ToString();
                        }
                        mySqlDataReader.Close();
                    }

                   
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                finally
                {
                    con.Close();
                }
            }

        }


        public void display3()
        {

            if (con.State != ConnectionState.Open)
            {
                try
                {
                    
                    con.Open();
                    string query = "SELECT COUNT(id) FROM employees WHERE status = @istatus and delete_date is  null";
                    using (MySqlCommand com = new MySqlCommand(query, con))
                    {
                        com.Parameters.AddWithValue("@istatus", "Inactive");
                        MySqlDataReader mySqlDataReader = com.ExecuteReader();
                       

                        if(mySqlDataReader.Read())
                        {
                            int count = Convert.ToInt32(mySqlDataReader[0]);
                            db3.Text = count.ToString();
                        }
                        mySqlDataReader.Close();
                    }

                   
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                finally
                {
                    con.Close();
                }
            }


        }


    }
}
