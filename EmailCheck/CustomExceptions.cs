using System;
using System.Collections.Generic;
using System.Text;

namespace EmailCheck
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME, INVALID_LAST_NAME, INVALID_MOBILE_NUMBER, INVALID_PASSWORD, INVALID_EMAIL
        }
        ExceptionType type;

        public CustomExceptions(ExceptionType type, string message) :base(message)
        {
            this.type = type;
        }
    }
}
