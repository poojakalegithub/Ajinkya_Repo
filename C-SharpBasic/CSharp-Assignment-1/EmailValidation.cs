using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp
{
    internal class EmailValidation
    {
        public void Validation()
        {
            Console.Write("Enter a Email : ");
            string Email = Console.ReadLine();
            int DotCount = 0;
            int AtCount = 0;
            int DoubleDotCount = 0;
            char[] EmailArray = Email.ToCharArray();
            int lastIndexArray = EmailArray.Length - 1;
         
            for (int i =0; i < EmailArray.Length-1; i++)
            {
                
               if (EmailArray[i] == '.' && EmailArray[i + 1] == '.')
               {
                       DoubleDotCount++;

               }

               else if (EmailArray[i] == '.')
               {
                        DotCount++;
               }

               if (EmailArray[i] == '@')
                {
                        AtCount++;
                }
                
            }

            if (DoubleDotCount == 0 && DotCount > 0 && AtCount == 1 &&
                EmailArray[0] != '@' && EmailArray[0] != '.' &&
                EmailArray[lastIndexArray] != '@' && EmailArray[lastIndexArray] != '.')
            {
                Console.WriteLine("Email is Valid.");
            }
            else
            {
                Console.WriteLine("Email is not valid.");
            }
        }      
    }
}
