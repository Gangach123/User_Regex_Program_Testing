using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using User_Regestartion;

namespace Regex_Problems
{
    public class Validation
    {

        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string email = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";
        public static string mobileNo = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string password = "^(?=.*[!@#$%^&*]{1})(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9@$!%*#?&]{8,}$";
        public static string password_2 = @"^(?=.*[A-Z])[[a-zA-Z1-9]{1}][[a-zA-Z0-9]{7,}]";
        public static string password_3 = @"^(?=.*[0-9])[a-zA-Z0-9]{8,}$";
        public static string password_4 = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        public static string mail = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";


        public Func<string, string> LValidateFirstName = data => Regex.IsMatch(data, firstName) ? "valid firstName" : throw new CustomException(CustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid firstName");
        public Func<string, string> LValidateLastName = data => Regex.IsMatch(data, lastName) ? "valid lastName" : throw new CustomException(CustomException.ExceptionType.INVALID_LASTNAME, "Invalid lastName");
        public Func<string, string> LValidateEmail = data => Regex.IsMatch(data, email) ? "valid email" : throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid email");
        public Func<string, string> LValidateMobileNo = data => Regex.IsMatch(data, mobileNo) ? "valid mobileNo" : throw new CustomException(CustomException.ExceptionType.INVALID_MOBILE_NO, "Invalid mobileNo");
        public Func<string, string> LValidatePassword = data => Regex.IsMatch(data, password) ? "valid password" : throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Invalid password");

        public string ValidateFirstName(string data)
        {
            bool result = Regex.IsMatch(data, firstName);
            if (result)
            {
                return "Valid firstName";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_FIRSTNAME, "Invalid firstName");
            }
        }
        public string ValidateLastName(string data)
        {
            bool result = Regex.IsMatch(data, lastName);
            if (result)
            {
                return "Valid lastName";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_LASTNAME, "Invalid lastName");
            }
        }
        public string ValidateEmail(string data)
        {
            bool result = Regex.IsMatch(data, email);
            if (result)
            {
                return "Valid email";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "Invalid email");
            }
        }
        public string ValidateMobileNo(string data)
        {
            bool result = Regex.IsMatch(data, mobileNo);
            if (result)
            {
                return "Valid mobileNo";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MOBILE_NO, "Invalid mobileNo");
            }
        }
        public string ValidatePassword(string data)
        {
            bool result = Regex.IsMatch(data, password);
            if (result)
            {
                return "Valid password";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "Invalid password");
            }
        }
    }
}
