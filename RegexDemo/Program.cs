using System;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular expression");

            //Pattern for characters
            string pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$";

            //Pattern for indian postal pin code
            string pincode = "^[0-9]{3}[ ]*[0-9]{3}$";

            //Passing inputs to character and pincode
            string[] inputs1 = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };
            string[] inputs2 = { "123456", "A87654", "12345B", "1N123G", "1234567", "1234" };

            Program pg = new Program();
            pg.ValidateChracters(inputs1, pattern);
            pg.ValidatePincode(inputs2, pincode);

        }

        /// <summary>
        /// Iterate and validate all string patterns
        /// Here we are checking valid or not with boolean IsMatch() method which will return true or false.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="regex"></param>
        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)
                {
                    Console.WriteLine(arr[i] + "------>" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "------>" + "Invalid");

                }
            }
        }

        public void ValidateChracters(string[] arr, string pincode)
        {
            Console.WriteLine("\nValidating for Characters");
            Regex regex1 = new Regex(pincode);
            IterateLoop(arr, regex1);
        }

        public void ValidatePincode(string[] arr, string pincode)
        {
            Console.WriteLine("\nValidate Indian postal pin code");
            Regex regex2 = new Regex(pincode);
            IterateLoop(arr, regex2);
        }

    }
}
