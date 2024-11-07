using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace EmployeeManagement
{
   public  class SalaryData
    {
        public string employeeId { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }
        public string phoneNumber { get; set; }

        public string position { get; set; }

        public int salary { get; set; }

        public static string connectionstring = "Server=127.0.0.1; Database=employee; User Id =root; Pwd=Polo$1234;";

        MySqlConnection connection = new MySqlConnection(connectionstring);

        public List<SalaryData> salaryEmployeeList()
        {
            List<SalaryData> listdata1 = new List<SalaryData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();
                    string selectdata = "SELECT * from employees where status = @active and delete_date is null";
                    MySqlCommand com = new MySqlCommand(selectdata, connection);
                    com.Parameters.AddWithValue("@active","Active");

                    MySqlDataReader mySqlDataReader = com.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        //id,employeeid,fullname,gender,phonenumber,
                        //position,image,salary,status
                        SalaryData employeedata = new SalaryData();
                        employeedata.employeeId = mySqlDataReader["employee_id"].ToString();
                        employeedata.Name = mySqlDataReader["full_name"].ToString();
                        employeedata.Gender = mySqlDataReader["gender"].ToString();
                        employeedata.phoneNumber = mySqlDataReader["phone_number"].ToString();
                        employeedata.position = mySqlDataReader["position"].ToString();
                        //employeedata.image = mySqlDataReader["image"].ToString();
                        employeedata.salary = (int)mySqlDataReader["salary"];
                        //employeedata.status = mySqlDataReader["status"].ToString();
                        listdata1.Add(employeedata);


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
            return listdata1;
        }
    }
}
