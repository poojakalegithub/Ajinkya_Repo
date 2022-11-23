
namespace C_Sharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal class GenericClass<T>
    {
        public T MyProperty { get; set; }

        public int Add(T number1, T number2)
        {
            dynamic value1 = number1;
            dynamic value2 = number2;
            return value1 + value2;
        }
        public string ConCat(T string1, T string2)
        {
            dynamic stringValue1 = string1;
            dynamic stringValue2 = string2;
            return stringValue1 + stringValue2;
        }
    }
}
