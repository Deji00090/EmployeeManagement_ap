using MySql.Data.MySqlClient;
using System.Data;


namespace EmployeeManagement
{
    //employee_id,full_name,gender,phone_number,position,image,salary,insert_date,status
    public class Employeedata
    {

        //id,employeeid,fullname,gender,phonenumber,
        //position,image,salary,status
        public int Id { get; set; }

        public string employeeId { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }

        public string phoneNumber { get; set; }

        public string position { get; set; }

        public string image { get; set; }

        public int salary { get; set; }

        public string status { get; set; }


        public static string connectionstring = "Server=127.0.0.1; Database=employee; User Id =root; Pwd=Polo$1234;";

        MySqlConnection connection = new MySqlConnection(connectionstring);

        public List<Employeedata> EmployeedataList()
        {
            List<Employeedata> listdata1 = new List<Employeedata>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {

                    connection.Open();
                    string selectdata = "SELECT * from employees where delete_date is null";
                    MySqlCommand com = new MySqlCommand(selectdata, connection);

                    MySqlDataReader mySqlDataReader = com.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        //id,employeeid,fullname,gender,phonenumber,
                        //position,image,salary,status
                        Employeedata employeedata = new Employeedata();
                        employeedata.employeeId = mySqlDataReader["employee_id"].ToString();
                        employeedata.Name = mySqlDataReader["full_name"].ToString();
                        employeedata.Gender = mySqlDataReader["gender"].ToString();
                        employeedata.phoneNumber = mySqlDataReader["phone_number"].ToString();
                        employeedata.position = mySqlDataReader["position"].ToString();
                        employeedata.image = mySqlDataReader["image"].ToString();
                        employeedata.salary = (int)mySqlDataReader["salary"];
                        employeedata.status = mySqlDataReader["status"].ToString();                     
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
