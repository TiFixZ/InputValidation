using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraitByWinForms
{
    internal class Validation
    {
        public static string TechnicalTask01(string input)
        {
            float number;
            if (float.TryParse(input, out number))
            {
                return input;
            }
            return "";
        }
        public static string TechnicalTask02(string input)
        {
            string result = "";
            if (input == null)
            {
                return result;
            }
            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    result += symbol;
                }
            }
            return result;
        }
    }
}
