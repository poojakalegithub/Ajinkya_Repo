// See https://aka.ms/new-console-template for more information

using System;
using static C_Sharp.Enum;

namespace C_Sharp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            //Bank bank = new Bank();
            //bank.Run();

            //Email Validation
            //Email email = new Email();
            //email.Validation();

            //Enum 
            //Console.WriteLine("Country {0} {1}", (int)Countries.INDIA, Countries.INDIA);
            //Console.WriteLine("Country {0} {1}", (int)Countries.AUSTRALIA, Countries.AUSTRALIA);
            //Console.WriteLine("Country {0} {1}", (int)Countries.USA, Countries.USA);
            //Console.WriteLine("Country {0} {1}", (int)Countries.JAPAN, Countries.JAPAN);
            //Console.WriteLine("Country {0} {1}", (int)Countries.FRANCE, Countries.FRANCE);
            //Console.WriteLine("Country {0} {1}", (int)Countries.ENGLAND, Countries.ENGLAND);
            //Console.ReadLine();

            //String Operation
            //StringOperation operation = new StringOperation();
            //operation.Operation();

            //Exceptions
            Exceptions exception = new Exceptions();
            exception.Exception();

            //Reading text file
            //ReadFile readFile= new ReadFile();
            //readFile.Read();

            //Salary in decending order.
            //EmployeeSalary employeeSalary = new EmployeeSalary();
            //employeeSalary.EmployeeData();

            //Student Details
            //StudentData studentData = new StudentData();
            //studentData.Display();

            //Generic Classes
            //GenericClass<int, string> generic = new GenericClass<int, string>();
            //Console.WriteLine("Addition = {0}",generic.Add(12, 20));
            //Console.WriteLine("Name = {0}",generic.ConCat("ajin", "kya"));

        }
    }
}