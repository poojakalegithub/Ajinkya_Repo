using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class ReadFile
    {
            String check;
            public void Read()
            {
                try
                {

                    StreamReader sr = new StreamReader(@"C:\Users\Ajinkya.Sonwane\source\repos\C-Sharp\CSharp-Assignment-2\C# Assignments – II.txt");

                    check = sr.ReadLine();

                    while (check != null)
                    {

                        Console.WriteLine(check);
                        check = sr.ReadLine();
                    }

                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }

            }
    }
}
