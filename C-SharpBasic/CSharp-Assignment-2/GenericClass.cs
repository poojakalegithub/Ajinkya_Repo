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

        public int Add(INT number1, INT number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            return value1 + value2;
        }
        public string ConCat(STRING string1, STRING string2)
        {
            dynamic stringValue1 = string1;
            dynamic stringValue2 = string2;
            return stringValue1 + stringValue2;

        }

    }
}