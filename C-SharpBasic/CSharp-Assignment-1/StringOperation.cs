using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    class StringOperation
    {
        public void stringOperation()
        {

            String name = "Ajinkya";
            String surname = "Sonawane";
            Console.Write("Enter a String : ");
            string Name = Console.ReadLine();
            char[] UserName = Name.ToCharArray();
            Array.Reverse(UserName);
            string reverseString = new string(UserName);

            Console.WriteLine("First name = {0}", name);
            Console.WriteLine("Last name  = {0} ", surname);
            Console.WriteLine(String.Compare(name, surname));
            Console.WriteLine(String.Concat(name, surname));
            Console.WriteLine(name.Count());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim('!'));
            Console.WriteLine(name.TrimEnd('!'));
            Console.WriteLine(name.TrimStart('A'));
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
            Console.WriteLine(name.Substring(5));
        }

    }

}
