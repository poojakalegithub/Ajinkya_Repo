using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Enum
    {
            public enum Countries
            {
                INDIA = 1, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Country {0} {1}", (int)Countries.INDIA, Countries.INDIA);
            Console.WriteLine("Country {0} {1}", (int)Countries.AUSTRALIA, Countries.AUSTRALIA);
            Console.WriteLine("Country {0} {1}", (int)Countries.USA, Countries.USA);
            Console.WriteLine("Country {0} {1}", (int)Countries.JAPAN, Countries.JAPAN);
            Console.WriteLine("Country {0} {1}", (int)Countries.FRANCE, Countries.FRANCE);
            Console.WriteLine("Country {0} {1}", (int)Countries.ENGLAND, Countries.ENGLAND);
            Console.ReadLine();
        }
    }
}

