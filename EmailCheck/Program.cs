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
            string mob = cr.MobileNoCondn();
            Console.WriteLine("Your Mobile Number is : "+mob);
            string pwd = cr.PassWordCondn();
            Console.WriteLine("Your password is : "+pwd);
            cr.CheckManyEmails();
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
            string emailPattern = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";      
            string validEmail = null;
            while (validate)
            {
                Console.WriteLine("Enter your Email (in format abc.xyz@pqr.co.in)");
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

        public string MobileNoCondn()
        {
            bool validate = true;
            string mobPattern = "[0-9]{2}[ ][1-9][0-9]{9}";
            string validMob= null;
            while (validate)
            {
                Console.WriteLine("Enter your Mobile Number(Country code & Mobile number separated by space)");
                string mob = Console.ReadLine();
                if (!(Regex.IsMatch(mob, mobPattern)))
                {
                    Console.WriteLine("Please enter a valid mobile number");
                }
                else
                {
                    validMob = mob;
                    validate = false;
                }
            }
            return validMob;
        }

        
        public string PassWordCondn()
        {
            bool validate = true;
            string pwdPattern = "((?=.*[A-Z])(?=.*[0-9])(?=.[@#$!%^&*()]{1})).{8,}";  
            string validPwd = null;
            while (validate)
            {
                Console.WriteLine("Enter your Password(Minimum 8 characters and atleast one Capital Letter and atleast one digit and exactly one special character)");
                string pwd = Console.ReadLine();
                if (!(Regex.IsMatch(pwd, pwdPattern)))
                {
                    Console.WriteLine("Please enter a valid password");
                }
                else
                {
                    validPwd = pwd;
                    validate = false;
                }
            }
            return validPwd;
        }

        public void CheckEmail(string email)
        {
            string emailPattern = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
            Console.WriteLine(Regex.IsMatch(email, emailPattern));
        }
        
        public void CheckManyEmails()
        {
            CheckEmail("abc@yahoo.com");
            CheckEmail("abc-100@yahoo.com");
            CheckEmail("abc.100@yahoo.com");
            CheckEmail("abc111@abc.com");
            CheckEmail("abc-100@abc.net");
            CheckEmail("abc.100@abc.com.au");
            CheckEmail("abc@1.com");
            CheckEmail("abc@gmail.com.com");
            CheckEmail("abc+100@gmail.com");

            CheckEmail("ab@c@.com.my");
            CheckEmail("abc123@gmail.a");
            CheckEmail("abc123@.com");
            CheckEmail("abc123@.com.com");
            CheckEmail(".abc@abc.com");
            CheckEmail("abc()*@gmail.com");
            CheckEmail("abc@%*.com");
            CheckEmail("abc..2002@gmail.com");
            CheckEmail("abc.@gmail.com");
            CheckEmail("abc@abc@gmail.com");
            CheckEmail("abc@gmail.com.1a");
            CheckEmail("abc@gmail.com.aa.au");

        }
        
    }
}
