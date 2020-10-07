using System;
using System.Text.RegularExpressions;

namespace EmailCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to User registration.");
            CheckRegex cr = new CheckRegex();
            string fname = cr.FirstNameCondn();
            Console.WriteLine(fname);

        }
    }

    class CheckRegex
    {
        public string FirstNameCondn()
        {
            bool validate = true;
            string firstNamePattern = "[A-Z][A-za-z]{2,}$";
            string validName = null;
            while (validate)
            {
                Console.WriteLine("Enter your First Name(First Letter Capital and min 3 alphabets)");
                string fName = Console.ReadLine();
                if (!(Regex.IsMatch(fName, firstNamePattern)))
                {
                    Console.WriteLine("Please enter a valid first name");
                }
                else
                {
                    validName = fName;
                    validate = false;
                }
            }
            return validName;
        }
    }
}
