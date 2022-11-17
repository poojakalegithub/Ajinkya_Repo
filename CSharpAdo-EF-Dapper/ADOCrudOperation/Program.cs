namespace AdoCrudOperation
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            String connectionString = @"Data Source=PUN-NB-LE3B55K\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {

                Console.WriteLine("Database connected successfully");
                string answer;
                do
                {
                    Console.WriteLine("Select from the options\n1.Create\n2.Show\n3.Update\n4.Delete");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Enter employee name = ");
                            String EmployeeName = Console.ReadLine();
                            Console.WriteLine("Enter employee salary = ");
                            int EmployeeSalary = int.Parse(Console.ReadLine());
                            String insertQuery = "INSERT INTO EmployeeData (EmployeeName, EmployeeSalary) VALUES('" + EmployeeName + "'," + EmployeeSalary + ")";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data stored successfully");
                            break;

                        case 2:

                            String displayQuery = "SELECT * FROM EmployeeData";
                            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = viewCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("Employee Id: " + dataReader.GetValue(0).ToString());
                                Console.WriteLine("Employee Name: " + dataReader.GetValue(1).ToString());
                                Console.WriteLine("Employee Salary: " + dataReader.GetValue(2).ToString());
                            }
                            dataReader.Close();
                            break;

                        case 3:

                            String employee_name;
                            int employee_id ,employee_salary;
                            Console.WriteLine("Enter the employee id of the entry to be Updated =");
                            employee_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name you would like to change =");
                            employee_name = Console.ReadLine();
                            Console.WriteLine("Enter the employee salary you like to change =");
                            employee_salary = int.Parse(Console.ReadLine());
                            String updateQuery_name = "UPDATE EmployeeData SET EmployeeName = '" + employee_name + "' WHERE EmployeeId = " + employee_id + "";
                            String updateQuery_salary = "UPDATE EmployeeData SET EmployeeSalary = '" + employee_salary + "' WHERE EmployeeId = " + employee_id + "";
                            SqlCommand updateCommand_name = new SqlCommand(updateQuery_name, sqlConnection);
                            SqlCommand updateCommand_salary = new SqlCommand(updateQuery_salary, sqlConnection);
                            updateCommand_name.ExecuteNonQuery();
                            updateCommand_salary.ExecuteNonQuery();
                            Console.WriteLine("Successfully updated");
                            break;

                        case 4:

                            int delete_id;
                            Console.WriteLine("Enter the id of the entry to be removed");
                            delete_id = int.Parse(Console.ReadLine());
                            String deleteQuery = "DELETE FROM EmployeeData WHERE EmployeeId = " + delete_id + "";
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully deleted");
                            break;
                        default:
                            Console.WriteLine("Please enter the valid choice");
                            break;
                    }
                    Console.WriteLine("Do you want to continue?");
                    answer = Console.ReadLine();
                } while (answer != "No");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }


        }
    }
}