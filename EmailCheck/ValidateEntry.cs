using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailCheck
{
    public class ValidateEntry
    {
        public string firstName { get; set; }
        private string _regexFirstName = "^[A-Z][A-za-z]{2,}$";
        public string lastName { get; set; }
        private string _regexLastName = "^[A-Z][A-Za-z]{2,}$";

        public string email { get; set; }
        private string _regexEmail = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public string password { get; set; }
        private string _regexPassword = "((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[@$#^!-+][a-zA-Z0-9]*$)).{8,}";

        public string mobileNumber { get; set; }
        private string _regexMobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";


        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, _regexFirstName);
        }

        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, _regexLastName);
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, _regexEmail);
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, _regexPassword);
        }
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, _regexMobileNumber);
        }
    }
}
