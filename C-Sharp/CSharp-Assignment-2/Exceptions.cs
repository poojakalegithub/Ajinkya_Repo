using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Exceptions
    {
        public void Exception()
        {
            int a = 10;
            int b = 0;
            int c = 0;

            try
            {
                c = a / b;
                string name = null;
                Console.WriteLine(c);
                Console.WriteLine(name.Length);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

   