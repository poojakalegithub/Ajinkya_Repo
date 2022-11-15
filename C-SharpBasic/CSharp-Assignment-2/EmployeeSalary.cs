using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class EmployeeSalary
    {
        int Emp_Id;
        string Emp_Name;
        int Emp_Salary;
        string Emp_Department;

        public void EmployeeData()
        {
            List<EmployeeSalary> employeeSalaries = new List<EmployeeSalary>()
            {
            new EmployeeSalary{Emp_Id = 111, Emp_Name = "Ajinkya",
                    Emp_Salary = 50000,Emp_Department = "XYZ"},
            new EmployeeSalary{Emp_Id = 112, Emp_Name = "Ganesh",
                    Emp_Salary = 65000,Emp_Department = "ABC"},
            new EmployeeSalary{Emp_Id = 123, Emp_Name = "Sudhanshu",
                    Emp_Salary = 45000,Emp_Department = "ABC"},
            new EmployeeSalary{Emp_Id = 134, Emp_Name = "Kartiki",
                    Emp_Salary = 20000,Emp_Department = "XYZ"},
            new EmployeeSalary{Emp_Id = 155, Emp_Name = "Sayali",
                    Emp_Salary = 70000,Emp_Department = "ABC"},
            new EmployeeSalary{Emp_Id = 125, Emp_Name = "Kajal",
                Emp_Salary = 40000,Emp_Department = "XYZ"},
            };

            var result_set = employeeSalaries.Where(emp => emp.Emp_Department == "XYZ").OrderByDescending(sal => sal.Emp_Salary);

           
            foreach (EmployeeSalary emp in result_set)
            {
                Console.WriteLine(emp.Emp_Id + " " +
                                emp.Emp_Name + " " +
                                emp.Emp_Salary + " " +
                                emp.Emp_Department);
            }

        }
    }
}


