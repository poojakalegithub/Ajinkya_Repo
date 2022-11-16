using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C_Sharp.Enum;

namespace C_Sharp
{
    public class Enum
    {
        public enum Countries
        {
            INDIA = 11 , AUSTRALIA = 12, USA = 15, JAPAN = 16, FRANCE = 14, ENGLAND = 13
        }
    }
    public class GetCountryCode : Enum
    {
        public void GetCode()
        {
            var CountriesCode = (Countries)11;
            Console.WriteLine(CountriesCode);

        }
    }
}

