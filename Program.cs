using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3_PS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string intString = "190";
            int intValue;
            if (int.TryParse(intString, out intValue))
            {
                Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            }
            else
            {
                Console.WriteLine("TryParse failed. Invalid input string.");
            }

            string doubleString = "1.90";
            try
            {
                double doubleValue = Convert.ToDouble(doubleString);
                Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Convert failed. Input value is too large or too small.");
            }

            string decimalString = "22.89";
            try
            {
                decimal decimalValue = decimal.Parse(decimalString);
                Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse failed. Invalid input format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Parse failed. Input value is too large or too small.");

            }
        }
    }
}
