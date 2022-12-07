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
            string connectionString = @"Data Source=PUN-NB-LE3B55K\SQLEXPRESS;Initial Catalog=EmployeeData;Integrated Security=True";
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
                            string EmployeeName = Console.ReadLine();
                            Console.WriteLine("Enter employee salary = ");
                            int EmployeeSalary = int.Parse(Console.ReadLine());
                            string insertQuery = $"INSERT INTO EmployeeData (EmployeeName, EmployeeSalary) VALUES( {EmployeeName}, {EmployeeSalary})";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data stored successfully");
                            break;

                        case 2:

                            string displayQuery = "SELECT * FROM EmployeeData";
                            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = viewCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("Employee Id:\t " + dataReader.GetValue(0).ToString());
                                Console.WriteLine("Employee Name:\t " + dataReader.GetValue(1).ToString());
                                Console.WriteLine("Employee Salary: " + dataReader.GetValue(2).ToString());
                            }
                            dataReader.Close();
                            break;

                        case 3:

                            string employeeName;
                            int employeeId, employeeSalary;
                            Console.WriteLine("Enter the employee id of the entry to be Updated =");
                            employeeId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name you would like to change =");
                            employeeName = Console.ReadLine();
                            Console.WriteLine("Enter the employee salary you like to change =");
                            employeeSalary = int.Parse(Console.ReadLine());
                            string updateQueryName = $"UPDATE EmployeeData SET EmployeeName = '{employeeName}'  WHERE EmployeeId = '{employeeId}'";
                            string updateQuerySalary = $"UPDATE EmployeeData SET EmployeeSalary = '{employeeSalary}'  WHERE EmployeeId = '{employeeId}'";
                            SqlCommand updateCommandName = new SqlCommand(updateQueryName, sqlConnection);
                            SqlCommand updateCommandSalary = new SqlCommand(updateQuerySalary, sqlConnection);
                            updateCommandName.ExecuteNonQuery();
                            updateCommandSalary.ExecuteNonQuery();
                            Console.WriteLine("Successfully updated");
                            break;

                        case 4:

                            int deleteId;
                            Console.WriteLine("Enter the id of the entry to be removed");
                            deleteId = int.Parse(Console.ReadLine());
                            string deleteQuery = $"DELETE FROM EmployeeData WHERE EmployeeId = {deleteId} ";
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