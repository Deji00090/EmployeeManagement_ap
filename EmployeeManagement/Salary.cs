using MySql.Data.MySqlClient;
using System.Data;

namespace EmployeeManagement
{
    public partial class Salary : UserControl
    {
        public Salary()
        {
            InitializeComponent();
            displaySalary();
            disablefield();
        }

        public void displaySalary()
        {
            SalaryData em = new SalaryData();
            List<SalaryData> employeedatas = em.salaryEmployeeList();
            dataGridView1.DataSource = employeedatas;
        }

        public void disablefield()
        {
            salaryemployeename.Enabled = false;
            salaryemployeeposition.Enabled = false;
            salaryemployeeid.Enabled = false;

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void salaryUpdate_btn_Click(object sender, EventArgs e)
        {

            string salary = salary_employee.Text;
            string id = salaryemployeeid.Text;

            DialogResult check = MessageBox.Show("Are you sure you want to update the " + salaryemployeeid.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string connectionstring = "Server=127.0.0.1; Database=employee; User Id =root; Pwd=Polo$1234;";
                MySqlConnection con = new MySqlConnection(connectionstring);

                string query = "UPDATE employees SET salary = @salary,update_date=@date where employee_id =@id";
                DateTime dateTime = DateTime.Today;
                try
                {
                    con.Open();
                    using(MySqlCommand com = new MySqlCommand(query, con))
                    {
                        com.Parameters.AddWithValue("@salary",salary);
                        com.Parameters.AddWithValue("@id", id);
                        com.Parameters.AddWithValue("@date", dateTime);
                        int affectedrow = com.ExecuteNonQuery();

                        if (affectedrow > 0)
                        {
                            MessageBox.Show("Salary updated successfully", "Confirmation message", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            displaySalary();
                        }
                        else
                        {
                            MessageBox.Show("No row was affected","No updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            }
            else
            {

            }
        }


  

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salaryemployeeid.Text = row.Cells[0].Value.ToString();
                salaryemployeename.Text = row.Cells[1].Value.ToString();
                salaryemployeeposition.Text = row.Cells[4].Value.ToString();
                salary_employee.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
