using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class GenericClass<INT, STRING>
    {
        public INT MyProperty { get; set; }
        public STRING MyValue { get; set; }

        public int Add(INT num1, INT num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }

        public string ConCat(STRING str1, STRING str2)
        {
            dynamic a = str1;
            dynamic b = str2;
            return a + b;

        }

    }
}