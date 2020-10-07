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
            string fname = cr.NameCondn(1);
            Console.WriteLine("Your First Name is :"+fname);
            string lname = cr.NameCondn(2);
            Console.WriteLine("Your Last Name is :"+ lname);
        }
    }

    class CheckRegex
    {
        public string NameCondn(int n)
        {
            bool validate = true;
            string namePattern = "[A-Z][A-za-z]{2,}$";
            string validName = null;
            string nameType = "First";
            if(n==2)
            {
                nameType = "Last";
            }
            while (validate)
            {
                Console.WriteLine("Enter your "+nameType+" Name(First Letter Capital and min 3 alphabets)");
                string name = Console.ReadLine();
                if (!(Regex.IsMatch(name, namePattern)))
                {
                    Console.WriteLine("Please enter a valid "+nameType+" name");
                }
                else
                {
                    validName = name;
                    validate = false;
                }
            }
            return validName;
        }
    }
}
