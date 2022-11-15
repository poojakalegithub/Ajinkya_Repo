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


            try {
                //for dividebyzero

                //int a = 10;
                //int b = 0;
                //int c = 0;
                //c = a / b;
                //Console.WriteLine(c);

                //for nullexception

                //string name = null;
                //Console.WriteLine(name.Length);

                //for generic exception

                //int[] arr = new int[3];
                //arr[0] = 11;
                //arr[1] = 12;
                //arr[2] = 22;
                //arr[3] = 33;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

   