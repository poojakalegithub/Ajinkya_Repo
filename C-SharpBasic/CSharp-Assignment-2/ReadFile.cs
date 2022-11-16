using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class ReadFile
    {
            String stringContainer;
            public void Read()
            {

                StreamReader streamReader = new StreamReader(@"C:\Users\Ajinkya.Sonwane\source\repos\C-Sharp\CSharp-Assignment-2\C# Assignments – II.txt");

                stringContainer = streamReader.ReadLine();

                try
                {
                   while (stringContainer != null)
                   {
                    Console.WriteLine(stringContainer);
                    stringContainer = streamReader.ReadLine();
                   }
                }

                catch (Exception e)
                {
                   Console.WriteLine("Exception: " + e.Message);
                }
                
                finally
                {
                   Console.WriteLine("Executing finally block.");
                   streamReader.Close();
                   Console.ReadLine();
            }
   
            }
    }
}
