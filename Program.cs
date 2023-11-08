using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using TryParse() to convert string type to int.
            string input = "123";
            int result;

            if (int.TryParse(input, out result))
            {
                Console.WriteLine("Conversion succeeded. Result: " + result);
            }
            else
            {
                Console.WriteLine("Conversion failed. Invalid input.");

            }
            

            //using Convert() to convert string type to double.
            string input2 = "123.45";

            try
            {
                double result2 = Convert.ToDouble(input2);
                Console.WriteLine("Conversion succeeded. Result: " + result2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception is"+e);
                Console.ReadKey();
            }
            

            //using Parse() to convert string type to decimal
            string input3 = "123.45";

            try
            {
                decimal result3 = decimal.Parse(input3);
                Console.WriteLine("Conversion succeeded. Result: " + result3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception is"+ex);
                Console.ReadKey();
            }
            

        }
    }
}
