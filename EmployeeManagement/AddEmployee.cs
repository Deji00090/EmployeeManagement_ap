using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EmployeeManagement
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
            //to display data from the database to the datagridview
            displayEmployeedat();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void displayEmployeedat()
        {
            Employeedata ed = new Employeedata();
            List<Employeedata> listdata = ed.EmployeedataList();

            // employeedata_dataGridView1
            employeedata_dataGridView1.DataSource = listdata;
        }
        private void employeedata_addbtn_Click(object sender, EventArgs e)
        {

            if (
                employeedata_name.Text != ""
                && employeedata_id.Text != ""
                && employeedata_gender.Text != ""
                && employeedata_position.Text != ""
                && employeedata_number.Text != ""
                && employee_status.Text != ""
                )
            {
                string connectionstring = "Server=127.0.0.1; Database= employee; User Id =root; Pwd=Polo$1234;";


                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) from employees where employee_id = @eid AND delete_date is null";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@eid", employeedata_id.Text);
                    Int64 count = (Int64)cmd.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show("Id already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        // code to get store the image directory into the created diectory
                        string path = Path.Combine(@"C:\\Users\\DELL\\source\\repos\\EmployeeManagement\\EmployeeManagement\\Directory\\"
                           + employeedata_id.Text.Trim() + " .jpg");

                        string directorypath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directorypath))
                        {
                            Directory.CreateDirectory(directorypath);
                        }

                        File.Copy(employeedata_picture.ImageLocation, path, true);

                        DateTime dateTime = DateTime.Today;

                        string insertdata = "insert into employees" +
                            "(employee_id,full_name,gender,phone_number,position," +
                            "image,salary,insert_date,status)" +
                            " values(@eid,@name,@gender,@number,@position,@image,@salary,@date,@status)";

                        using (MySqlCommand com = new MySqlCommand(insertdata, con))
                        {
                            com.Parameters.AddWithValue("@eid", employeedata_id.Text);
                            com.Parameters.AddWithValue("@name", employeedata_name.Text);
                            com.Parameters.AddWithValue("@gender", employeedata_gender.Text);
                            com.Parameters.AddWithValue("@number", employeedata_number.Text);
                            com.Parameters.AddWithValue("@position", employeedata_position.Text);
                            com.Parameters.AddWithValue("@image", path);
                            com.Parameters.AddWithValue("@salary", 0);
                            com.Parameters.AddWithValue("@status", employee_status.Text);
                            com.Parameters.AddWithValue("@date", dateTime);
                            com.ExecuteNonQuery();

                            displayEmployeedat();
                            MessageBox.Show("Added Succesfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearfield();
                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeedata_importbtn_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Images Files (*.jpg; *.png) | *.jpg; *.png";
                string imagepath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    employeedata_picture.ImageLocation = imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeedata_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void employeedata_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = employeedata_dataGridView1.Rows[e.RowIndex];                 
                employeedata_id.Text = row.Cells[1].Value.ToString();               
                employeedata_name.Text = row.Cells[2].Value.ToString();
                employeedata_gender.Text = row.Cells[3].Value.ToString();
                employeedata_number.Text = row.Cells[4].Value.ToString();
                employeedata_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    employeedata_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    employeedata_picture.Image = null;
                }

                employee_status.Text = row.Cells[8].Value.ToString();

            }
        }

        private void clearfield()
        {
            employeedata_name.Text = "";
            employeedata_id.Text = "";
            employeedata_gender.SelectedIndex = -1;
            employeedata_position.SelectedIndex = -1;
            employeedata_number.Text = "";
            employee_status.SelectedIndex = -1;
            employeedata_picture.Image = null;
        }
        private void employeedata_updatebtn_Click(object sender, EventArgs e)
        {
            if (
              employeedata_name.Text == ""
              || employeedata_id.Text == ""
              || employeedata_gender.Text == ""
              || employeedata_position.Text == ""
              || employeedata_number.Text == ""
              || employee_status.Text == ""
              || employeedata_picture.Image == null
              )
            {
                MessageBox.Show("Fill in the empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionstring = "Server=127.0.0.1; Database= employee; User Id =root; Pwd=Polo$1234;";
                MySqlConnection con = new MySqlConnection(connectionstring);
                DialogResult check = MessageBox.Show("Are you sure you want to update employee id :"
                    + employeedata_id.Text.Trim(),"Confirmation Message", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                DateTime date = DateTime.Today;

                if(check  == DialogResult.Yes)
                {
                    try
                    {
                       // employee_id,full_name,gender,phone_number,position,salary,upate_date,status
                        con.Open();
                        string update2 = "UPDATE employees SET  full_name = @fullname," +
                            "gender = @gender,phone_number = @number,position = @position1," +
                            "update_date= @date, status=@status WHERE  employee_id = @eid";

                        using (MySqlCommand com = new MySqlCommand(update2,con))
                        {
                            
                            com.Parameters.AddWithValue("@fullname", employeedata_name.Text.Trim());
                            com.Parameters.AddWithValue("@gender", employeedata_gender.Text.Trim());
                            com.Parameters.AddWithValue("@number", employeedata_number.Text.Trim());
                            com.Parameters.AddWithValue("@position1", employeedata_position.Text.Trim());
                            com.Parameters.AddWithValue("@date", date);
                            com.Parameters.AddWithValue("@status", employee_status.Text.Trim());                            
                            com.Parameters.AddWithValue("@eid", employeedata_id.Text.Trim());
                         
                            int affectedrow = com.ExecuteNonQuery();

                            if(affectedrow > 0)
                            {

                                displayEmployeedat();
                                MessageBox.Show("Updated Succesfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfield();
                            }
                            else
                            {
                                MessageBox.Show("No row updated!!",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                         
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error : " + ex);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You won't update the employee data?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               


            }
      
        }
         private void employeedata_clearbtn_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void employeedata_deletebtn_Click(object sender, EventArgs e)
        {
            if (
               employeedata_name.Text != ""
               && employeedata_id.Text != ""
               && employeedata_gender.Text != ""
               && employeedata_position.Text != ""
               && employeedata_number.Text != ""
               && employee_status.Text != ""
               && employeedata_picture.Image != null
               )
            {
                string connectionstring = "Server=127.0.0.1; Database= employee; User Id =root; Pwd=Polo$1234;";
                DialogResult check = MessageBox.Show("Are you sure you want to delete the information"
                    , "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection con = new MySqlConnection(connectionstring))
                        {
                            con.Open();

                            // code to get store the image directory into the created diectory
                            

                            DateTime dateTime = DateTime.Today;

                            string updatedata = "UPDATE  employees SET " +
                                 "delete_date = @date  WHERE employee_id = @eid";


                            using (MySqlCommand com = new MySqlCommand(updatedata, con))
                            {

                                
                                com.Parameters.AddWithValue("@date", dateTime);
                                com.Parameters.AddWithValue("@eid", employeedata_id.Text.Trim());
                                com.ExecuteNonQuery();

                                displayEmployeedat();
                                MessageBox.Show("Deleteded Succesfully!",
                                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfield();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in the empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
