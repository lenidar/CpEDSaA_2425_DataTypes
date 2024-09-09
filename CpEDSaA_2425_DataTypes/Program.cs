using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEDSaA_2425_DataTypes
{
    internal class Program
    {
        // Please use Console App (.Net Framework)
        static void Main(string[] args)
        {
            string uInput = "";
            int finalNumber = 0;

            Console.WriteLine("This is the parsing demonstration. Please enter a number: ");
            uInput = Console.ReadLine();

            Console.WriteLine("\nConverting input into a number...");
            // parsing a string into a number
            #region BeforeTryParse
            //try
            //{
            //    finalNumber = int.Parse(uInput);

            //    Console.WriteLine("\nThe number is " + finalNumber);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("\nYour input is not a number...");
            //} 
            #endregion
            if (int.TryParse(uInput, out finalNumber))
            {
                Console.WriteLine("The final number is " + finalNumber);
            }
            else
            {
                Console.WriteLine("Failed to convert the number");
            }

            // this is just to make the console stop and wait for me to quit the application
            Console.ReadKey(); 
        }

        /// <summary>
        /// This is a breakdown of how try parse works
        /// </summary>
        /// <param name="input">the string input to be converted to a number</param>
        /// <param name="num">the number output. will output 0 by default</param>
        /// <returns>true if conversion is successful. returns false by default</returns>
        static bool MyTryParse(string input, out int num)
        {
            int cNum = 0;
            bool success = false;

            try
            {
                cNum = int.Parse(input);
                success = true;
            }
            catch (Exception e)
            {
            }

            num = cNum;
            return success;
        }
    }
}
