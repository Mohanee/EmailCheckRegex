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
            string email = cr.EmailCondn();
            Console.WriteLine("Your Email is : " + email);
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

        public string EmailCondn()
        {
            bool validate = true;
            string emailPattern = "[a-z]{3,}[.a-z]{1,}[@][a-z]{2,}[.][a-z]{2,}[.]{a-z}{1,}$";
            string validEmail = null;
            while (validate)
            {
                Console.WriteLine("Enter your Email (First Letter Capital and min 3 alphabets)");
                string email = Console.ReadLine();
                if (!(Regex.IsMatch(email, emailPattern)))
                {
                    Console.WriteLine("Please enter a valid email");
                }
                else
                {
                    validEmail = email;
                    validate = false;
                }
            }
            return validEmail;
        }
        
    }
}
